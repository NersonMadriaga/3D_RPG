using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovements : MonoBehaviour
{
    private InputManager inputManager;
    private Animator animator;
    private Transform cam;

    private int isWalkingHash;
    private int isRunningHash;

    private bool isRunning;
    private bool isWalking;

    private float turnSmoothTime = 0.1f;
    private float turnSmoothVelocity;
    // Start is called before the first frame update
    void Start()
    {
        inputManager = InputManager.Instance;
        animator = GetComponent<Animator>();

        InitialProperties();
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
        HandleRotation();
    }

    private void InitialProperties()
    {
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        Cursor.visible = false;
        cam = Camera.main.transform;
    }

    private void HandleMovement()
    {
        isWalking = animator.GetBool(isWalkingHash);
        isRunning = animator.GetBool(isRunningHash);

        if(inputManager.IsMovePressed() && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if(!inputManager.IsMovePressed() && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if((inputManager.IsMovePressed() && inputManager.IsRunning()) && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }

        if((!inputManager.IsMovePressed() || !inputManager.IsRunning()) && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }
    }

    private void HandleRotation()
    {
        if (inputManager.GetDirection().magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(inputManager.GetDirection().x, inputManager.GetDirection().y) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);
        }
    }
}
