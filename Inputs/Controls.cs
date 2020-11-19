// GENERATED AUTOMATICALLY FROM 'Assets/IL3DN/Inputs/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""playercontrol"",
            ""id"": ""396a3535-8ff7-4a48-80e7-f51dfb9641fe"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Button"",
                    ""id"": ""29df96b7-bf95-48f3-bd8b-5c9f3f9a7e5e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""033b472b-21ea-41f3-ac65-67bae82fbd06"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""a3e4185b-6c26-473b-a9ba-b32b757d209e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d0206273-ca43-4163-a8a0-04c8eb1e6cc3"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8806a189-b650-414f-8d39-f8d1689d3c84"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""80bb7a2c-a0f7-4648-a97f-aa91d751dd89"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4c741f4d-c76c-4ef1-9b41-a49873b9f47c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9935dc37-0ea0-429d-a644-d150512bdf60"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6fe494de-d7fb-4aee-994f-54b8578e470e"",
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
                    ""id"": ""eae064e5-4fbc-41bd-97a8-70f396ade5a5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
                }
            ]
        }
    ]
}");
        // playercontrol
        m_playercontrol = asset.FindActionMap("playercontrol", throwIfNotFound: true);
        m_playercontrol_Move = m_playercontrol.FindAction("Move", throwIfNotFound: true);
        m_playercontrol_Jump = m_playercontrol.FindAction("Jump", throwIfNotFound: true);
        m_playercontrol_Action = m_playercontrol.FindAction("Action", throwIfNotFound: true);
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

    // playercontrol
    private readonly InputActionMap m_playercontrol;
    private IPlayercontrolActions m_PlayercontrolActionsCallbackInterface;
    private readonly InputAction m_playercontrol_Move;
    private readonly InputAction m_playercontrol_Jump;
    private readonly InputAction m_playercontrol_Action;
    public struct PlayercontrolActions
    {
        private @Controls m_Wrapper;
        public PlayercontrolActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_playercontrol_Move;
        public InputAction @Jump => m_Wrapper.m_playercontrol_Jump;
        public InputAction @Action => m_Wrapper.m_playercontrol_Action;
        public InputActionMap Get() { return m_Wrapper.m_playercontrol; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayercontrolActions set) { return set.Get(); }
        public void SetCallbacks(IPlayercontrolActions instance)
        {
            if (m_Wrapper.m_PlayercontrolActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnJump;
                @Action.started -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnAction;
                @Action.performed -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnAction;
                @Action.canceled -= m_Wrapper.m_PlayercontrolActionsCallbackInterface.OnAction;
            }
            m_Wrapper.m_PlayercontrolActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Action.started += instance.OnAction;
                @Action.performed += instance.OnAction;
                @Action.canceled += instance.OnAction;
            }
        }
    }
    public PlayercontrolActions @playercontrol => new PlayercontrolActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    public interface IPlayercontrolActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAction(InputAction.CallbackContext context);
    }
}
