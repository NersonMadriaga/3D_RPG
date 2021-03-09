
using UnityEngine;

public class CharacterMovements : MonoBehaviour
{
    public static CharacterMovements Instance { get; private set; }
    private CharacterController controller;
    private InputManager inputManager;
    private Animator animator;
    private Transform cam;

    private int isWalkingHash;
    private int isRunningHash;
    private int isCrouchingHash;
    private int isBattleHash;
    private int isJumpingHash;
    private int isRunJumpingHash;

    private bool isRunning;
    private bool isWalking;

    // Rotation variables
    private float turnSmoothTime;
    private float turnSmoothVelocity;

    // Jump variables
    private float verticalVelocity;
    private float gravity;
    private float jumpForce;

    private void Awake()
    {
        Instance = this;
    }

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
        controller = GetComponent<CharacterController>();

        turnSmoothTime = 0.1f;

        gravity = 14f;
        jumpForce = 10f;

        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        isCrouchingHash = Animator.StringToHash("isCrouching");
        isBattleHash = Animator.StringToHash("isBattle");
        isJumpingHash = Animator.StringToHash("isJumping");
        isRunJumpingHash = Animator.StringToHash("isRunJumping");

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        cam = Camera.main.transform;
    }

    private void HandleMovement()
    {
        HandleNormalRunWalkMovement();
        HandleCrouchMovement();
        HandleBattleStance();
        HandleJump();
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
    private void HandleJump()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if (inputManager.IsJumping() && inputManager.IsMovePressed())
            {
                verticalVelocity = jumpForce;
                inputManager.SetIsJumping(false);
                animator.SetTrigger(isJumpingHash);
                animator.SetBool(isRunJumpingHash, true);
            }

            if (inputManager.IsJumping() && !inputManager.IsMovePressed())
            {
                verticalVelocity = jumpForce;
                inputManager.SetIsJumping(false);
                animator.SetTrigger(isJumpingHash);
            }

            if(verticalVelocity >= 15f)
            {
                animator.SetBool("isEasyLanding", false);
            }else
            {

            }
            animator.SetBool("isGrounded", true);
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
            Debug.Log(verticalVelocity + " Vertical Velocity");
            animator.SetBool("isGrounded", false);
        }

        Vector3 moveVector = new Vector3(0f, verticalVelocity, 0f);
        controller.Move(moveVector * Time.deltaTime);
    }

    private void HandleBattleStance()
    {
        if(inputManager.IsInBattle() && !inputManager.IsMovePressed())
        {
            animator.SetBool(isBattleHash, true);
        }else
        {
            animator.SetBool(isBattleHash, false);
        }
    }

    private void HandleCrouchMovement()
    {
        if (inputManager.IsCrouching())
        {
            animator.SetBool(isCrouchingHash, true);
        } else
        {
            animator.SetBool(isCrouchingHash, false);
        }
    }

    private void HandleNormalRunWalkMovement()
    {
        isWalking = animator.GetBool(isWalkingHash);
        isRunning = animator.GetBool(isRunningHash);

        if (inputManager.IsMovePressed() && !isWalking)
        {
            animator.SetBool(isWalkingHash, true);
        }

        if (!inputManager.IsMovePressed() && isWalking)
        {
            animator.SetBool(isWalkingHash, false);
        }

        if ((inputManager.IsMovePressed() && inputManager.IsRunning()) && !isRunning)
        {
            animator.SetBool(isRunningHash, true);
        }

        if ((!inputManager.IsMovePressed() || !inputManager.IsRunning()) && isRunning)
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
