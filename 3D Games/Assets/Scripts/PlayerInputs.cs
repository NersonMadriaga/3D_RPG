// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Player Movements"",
            ""id"": ""60d6592e-70e2-41aa-b59e-0a895d398e62"",
            ""actions"": [
                {
                    ""name"": ""Movements"",
                    ""type"": ""PassThrough"",
                    ""id"": ""89b7c906-a02a-499f-b253-411e0eac8073"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Running"",
                    ""type"": ""Button"",
                    ""id"": ""3f7f092f-05f0-4fcf-804e-1480ef541e03"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4e96bc38-9199-426a-ba65-2e1502a1a8a9"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""9b4ba241-4709-4313-818c-2d79029df9e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ab9e7593-5060-41af-a069-f6104104f1b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""BattleStance"",
                    ""type"": ""Button"",
                    ""id"": ""c9f12548-374a-40a1-acf1-6dd421bb9675"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""fe712c5a-02ab-4be0-b70f-2542ec8dd632"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movements"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3a202e03-ce37-455c-8e1b-171eef4592fd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""590633c1-638a-4d0a-82a7-5ade6644a27e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b7685282-2535-434f-9795-87cf7589115d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""32117b89-7aaa-463a-a97f-68d6444b6f16"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Movements"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c0e65406-37c7-4e6e-ab85-9ffb0131a930"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Running"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d02010d2-766f-4f0f-9a9d-50640faf860d"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3e13224e-23c1-4e33-9cc7-aa60ea1d627a"",
                    ""path"": ""<Keyboard>/leftCtrl"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""918bb569-a117-4d98-ae86-2170780eb701"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6142df5b-199d-47f1-87a4-521761525dc9"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard and Mouse"",
                    ""action"": ""BattleStance"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard and Mouse"",
            ""bindingGroup"": ""Keyboard and Mouse"",
            ""devices"": []
        }
    ]
}");
        // Player Movements
        m_PlayerMovements = asset.FindActionMap("Player Movements", throwIfNotFound: true);
        m_PlayerMovements_Movements = m_PlayerMovements.FindAction("Movements", throwIfNotFound: true);
        m_PlayerMovements_Running = m_PlayerMovements.FindAction("Running", throwIfNotFound: true);
        m_PlayerMovements_Look = m_PlayerMovements.FindAction("Look", throwIfNotFound: true);
        m_PlayerMovements_Crouch = m_PlayerMovements.FindAction("Crouch", throwIfNotFound: true);
        m_PlayerMovements_Jump = m_PlayerMovements.FindAction("Jump", throwIfNotFound: true);
        m_PlayerMovements_BattleStance = m_PlayerMovements.FindAction("BattleStance", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Player Movements
    private readonly InputActionMap m_PlayerMovements;
    private IPlayerMovementsActions m_PlayerMovementsActionsCallbackInterface;
    private readonly InputAction m_PlayerMovements_Movements;
    private readonly InputAction m_PlayerMovements_Running;
    private readonly InputAction m_PlayerMovements_Look;
    private readonly InputAction m_PlayerMovements_Crouch;
    private readonly InputAction m_PlayerMovements_Jump;
    private readonly InputAction m_PlayerMovements_BattleStance;
    public struct PlayerMovementsActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerMovementsActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movements => m_Wrapper.m_PlayerMovements_Movements;
        public InputAction @Running => m_Wrapper.m_PlayerMovements_Running;
        public InputAction @Look => m_Wrapper.m_PlayerMovements_Look;
        public InputAction @Crouch => m_Wrapper.m_PlayerMovements_Crouch;
        public InputAction @Jump => m_Wrapper.m_PlayerMovements_Jump;
        public InputAction @BattleStance => m_Wrapper.m_PlayerMovements_BattleStance;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovements; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementsActions instance)
        {
            if (m_Wrapper.m_PlayerMovementsActionsCallbackInterface != null)
            {
                @Movements.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnMovements;
                @Movements.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnMovements;
                @Movements.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnMovements;
                @Running.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnRunning;
                @Running.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnRunning;
                @Running.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnRunning;
                @Look.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnLook;
                @Crouch.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnCrouch;
                @Crouch.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnCrouch;
                @Crouch.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnCrouch;
                @Jump.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnJump;
                @BattleStance.started -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnBattleStance;
                @BattleStance.performed -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnBattleStance;
                @BattleStance.canceled -= m_Wrapper.m_PlayerMovementsActionsCallbackInterface.OnBattleStance;
            }
            m_Wrapper.m_PlayerMovementsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movements.started += instance.OnMovements;
                @Movements.performed += instance.OnMovements;
                @Movements.canceled += instance.OnMovements;
                @Running.started += instance.OnRunning;
                @Running.performed += instance.OnRunning;
                @Running.canceled += instance.OnRunning;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Crouch.started += instance.OnCrouch;
                @Crouch.performed += instance.OnCrouch;
                @Crouch.canceled += instance.OnCrouch;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @BattleStance.started += instance.OnBattleStance;
                @BattleStance.performed += instance.OnBattleStance;
                @BattleStance.canceled += instance.OnBattleStance;
            }
        }
    }
    public PlayerMovementsActions @PlayerMovements => new PlayerMovementsActions(this);
    private int m_KeyboardandMouseSchemeIndex = -1;
    public InputControlScheme KeyboardandMouseScheme
    {
        get
        {
            if (m_KeyboardandMouseSchemeIndex == -1) m_KeyboardandMouseSchemeIndex = asset.FindControlSchemeIndex("Keyboard and Mouse");
            return asset.controlSchemes[m_KeyboardandMouseSchemeIndex];
        }
    }
    public interface IPlayerMovementsActions
    {
        void OnMovements(InputAction.CallbackContext context);
        void OnRunning(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnCrouch(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnBattleStance(InputAction.CallbackContext context);
    }
}
