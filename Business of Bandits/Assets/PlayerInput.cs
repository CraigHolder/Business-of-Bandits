// GENERATED AUTOMATICALLY FROM 'Assets/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Ferret"",
            ""id"": ""e24abf81-f474-40de-b366-e5be8183159e"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e0f38e5a-6ae8-45bc-a404-c382fe07aa29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c400ebbe-e6ee-4e05-9b9c-6d87f7fe8b7a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Back"",
                    ""type"": ""PassThrough"",
                    ""id"": ""046f0218-a4bc-43fa-8cfc-4f304587acca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""PassThrough"",
                    ""id"": ""738051ab-3728-4a8d-aa64-5dfa692ac3b9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c188ba2d-f009-4644-b0af-afdf4d2c7e7e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveV2Forward"",
                    ""type"": ""Button"",
                    ""id"": ""0d3633d4-18e9-4207-84b9-c8ae972cdf6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveV2Right"",
                    ""type"": ""Button"",
                    ""id"": ""25c766cb-447e-4acd-b6c2-988e4a83b406"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1fffb6d0-4eae-4b6f-93ea-635b8d13a016"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ce1be14-df0c-4d99-a7f2-51c063082606"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd2c8757-6119-4cad-890d-59156e8fd345"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Back"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51add603-b22c-4b1f-91fa-d2d709798be6"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02384f12-28b4-47a9-8745-6def2be4151f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Forward"",
                    ""id"": ""bd1574df-f119-4729-a8c9-0ae63913b2f2"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV2Forward"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1f65db5a-eb2f-4a22-82a2-255f6f41ffcd"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV2Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""e3bed9e1-d7fa-42e3-9327-241b581731c3"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV2Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Right"",
                    ""id"": ""4ecd9ad9-9275-41ff-abc2-d3b58999290b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV2Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f1ffd171-ee76-4952-b306-bd26648ce292"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV2Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""7dd98466-2f0e-4870-8281-e39a5f5b3e8e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveV2Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Ferret
        m_Ferret = asset.FindActionMap("Ferret", throwIfNotFound: true);
        m_Ferret_Jump = m_Ferret.FindAction("Jump", throwIfNotFound: true);
        m_Ferret_Forward = m_Ferret.FindAction("Forward", throwIfNotFound: true);
        m_Ferret_Back = m_Ferret.FindAction("Back", throwIfNotFound: true);
        m_Ferret_Left = m_Ferret.FindAction("Left", throwIfNotFound: true);
        m_Ferret_Right = m_Ferret.FindAction("Right", throwIfNotFound: true);
        m_Ferret_MoveV2Forward = m_Ferret.FindAction("MoveV2Forward", throwIfNotFound: true);
        m_Ferret_MoveV2Right = m_Ferret.FindAction("MoveV2Right", throwIfNotFound: true);
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

    // Ferret
    private readonly InputActionMap m_Ferret;
    private IFerretActions m_FerretActionsCallbackInterface;
    private readonly InputAction m_Ferret_Jump;
    private readonly InputAction m_Ferret_Forward;
    private readonly InputAction m_Ferret_Back;
    private readonly InputAction m_Ferret_Left;
    private readonly InputAction m_Ferret_Right;
    private readonly InputAction m_Ferret_MoveV2Forward;
    private readonly InputAction m_Ferret_MoveV2Right;
    public struct FerretActions
    {
        private @PlayerInput m_Wrapper;
        public FerretActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Ferret_Jump;
        public InputAction @Forward => m_Wrapper.m_Ferret_Forward;
        public InputAction @Back => m_Wrapper.m_Ferret_Back;
        public InputAction @Left => m_Wrapper.m_Ferret_Left;
        public InputAction @Right => m_Wrapper.m_Ferret_Right;
        public InputAction @MoveV2Forward => m_Wrapper.m_Ferret_MoveV2Forward;
        public InputAction @MoveV2Right => m_Wrapper.m_Ferret_MoveV2Right;
        public InputActionMap Get() { return m_Wrapper.m_Ferret; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(FerretActions set) { return set.Get(); }
        public void SetCallbacks(IFerretActions instance)
        {
            if (m_Wrapper.m_FerretActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_FerretActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_FerretActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_FerretActionsCallbackInterface.OnJump;
                @Forward.started -= m_Wrapper.m_FerretActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_FerretActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_FerretActionsCallbackInterface.OnForward;
                @Back.started -= m_Wrapper.m_FerretActionsCallbackInterface.OnBack;
                @Back.performed -= m_Wrapper.m_FerretActionsCallbackInterface.OnBack;
                @Back.canceled -= m_Wrapper.m_FerretActionsCallbackInterface.OnBack;
                @Left.started -= m_Wrapper.m_FerretActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_FerretActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_FerretActionsCallbackInterface.OnLeft;
                @Right.started -= m_Wrapper.m_FerretActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_FerretActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_FerretActionsCallbackInterface.OnRight;
                @MoveV2Forward.started -= m_Wrapper.m_FerretActionsCallbackInterface.OnMoveV2Forward;
                @MoveV2Forward.performed -= m_Wrapper.m_FerretActionsCallbackInterface.OnMoveV2Forward;
                @MoveV2Forward.canceled -= m_Wrapper.m_FerretActionsCallbackInterface.OnMoveV2Forward;
                @MoveV2Right.started -= m_Wrapper.m_FerretActionsCallbackInterface.OnMoveV2Right;
                @MoveV2Right.performed -= m_Wrapper.m_FerretActionsCallbackInterface.OnMoveV2Right;
                @MoveV2Right.canceled -= m_Wrapper.m_FerretActionsCallbackInterface.OnMoveV2Right;
            }
            m_Wrapper.m_FerretActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Back.started += instance.OnBack;
                @Back.performed += instance.OnBack;
                @Back.canceled += instance.OnBack;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @MoveV2Forward.started += instance.OnMoveV2Forward;
                @MoveV2Forward.performed += instance.OnMoveV2Forward;
                @MoveV2Forward.canceled += instance.OnMoveV2Forward;
                @MoveV2Right.started += instance.OnMoveV2Right;
                @MoveV2Right.performed += instance.OnMoveV2Right;
                @MoveV2Right.canceled += instance.OnMoveV2Right;
            }
        }
    }
    public FerretActions @Ferret => new FerretActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IFerretActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
        void OnBack(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnRight(InputAction.CallbackContext context);
        void OnMoveV2Forward(InputAction.CallbackContext context);
        void OnMoveV2Right(InputAction.CallbackContext context);
    }
}
