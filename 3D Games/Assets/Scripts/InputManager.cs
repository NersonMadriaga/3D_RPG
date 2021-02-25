using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance { get; private set; }

    private PlayerInputs playerInputs;

    private Vector2 direction;

    private bool movePressed;
    private bool isRunning;

    private void Awake()
    {
        Instance = this;
    }

    private void OnEnable()
    {
        if(playerInputs == null)
        {
            playerInputs = new PlayerInputs();

            HandleInputs();
        }

        playerInputs.Enable();
    }

    private void OnDisable()
    {
        playerInputs.Disable();
    }

    private void HandleInputs()
    {
        HandleWASDInputs();
        HandleRunningInputs();
    }

    private void HandleWASDInputs()
    {
        playerInputs.PlayerMovements.Movements.performed += inputKeys =>
        {
            direction = inputKeys.ReadValue<Vector2>();
            movePressed = direction.x != 0f || direction.y != 0f;
        };
    }
    private void HandleRunningInputs() => playerInputs.PlayerMovements.Running.performed += btn => isRunning = btn.ReadValueAsButton();
    public Vector2 GetDirection() => direction;
    public bool IsMovePressed() => movePressed;
    public bool IsRunning() => isRunning;
}
