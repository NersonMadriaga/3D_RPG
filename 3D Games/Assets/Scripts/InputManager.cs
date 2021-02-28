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
    private bool isCrouching;
    private bool isJumping;
    private bool isInBattle;

    private void Awake()
    {
        Instance = this;
        isInBattle = false;
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
        HandleCrouchInputs();
        HandleJumpInputs();
        HandleBattleStance();
    }

    private void HandleRunningInputs() => playerInputs.PlayerMovements.Running.performed += btn => isRunning = btn.ReadValueAsButton();
    private void HandleCrouchInputs() => playerInputs.PlayerMovements.Crouch.performed += btn => isCrouching = btn.ReadValueAsButton();
    private void HandleJumpInputs() => playerInputs.PlayerMovements.Jump.performed += btn => isJumping = btn.ReadValueAsButton();
    private void HandleBattleStance() => playerInputs.PlayerMovements.BattleStance.performed += _ => isInBattle = !isInBattle;
    public Vector2 GetDirection() => direction;
    public bool IsMovePressed() => movePressed;
    public bool IsRunning() => isRunning;
    public bool IsCrouching() => isCrouching;
    public bool IsInBattle() => isInBattle;
    public bool IsJumping() => isJumping;
    private void HandleWASDInputs()
    {
        playerInputs.PlayerMovements.Movements.performed += inputKeys =>
        {
            direction = inputKeys.ReadValue<Vector2>();
            movePressed = direction.x != 0f || direction.y != 0f;
        };
    }
}
