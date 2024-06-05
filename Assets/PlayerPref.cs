//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/PlayerPref.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerPref : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerPref()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerPref"",
    ""maps"": [
        {
            ""name"": ""action"",
            ""id"": ""a7160998-d4c4-4652-82e6-86807c545c34"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""bf304456-cbc7-41ff-9764-5796f8674850"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""ee6abf1c-35bf-4f87-be7b-290a7f225e2d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Touch"",
                    ""type"": ""Button"",
                    ""id"": ""63983121-f70e-4508-92ac-3f187bf6669f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchPosition"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2e208080-91f5-4b07-bc70-1d2c015dd3a6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""TouchLook"",
                    ""type"": ""Button"",
                    ""id"": ""1b130086-22b1-4b43-9988-c709bdc88240"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""f0312cd0-7823-4fa4-8e0c-7d237a8f792e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e732ff2a-893a-49b5-acc4-1d61c357298e"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""678450db-f061-4f6d-a064-73770972cd9f"",
                    ""path"": ""<Touchscreen>/touch0/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Touch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa55adc5-c243-4d09-abf8-7bd5712efe5f"",
                    ""path"": ""<Touchscreen>/primaryTouch/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchPosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b46d872f-f63d-416d-83c1-7fb38a8db246"",
                    ""path"": ""<Touchscreen>/touch1/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TouchLook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // action
        m_action = asset.FindActionMap("action", throwIfNotFound: true);
        m_action_Move = m_action.FindAction("Move", throwIfNotFound: true);
        m_action_Look = m_action.FindAction("Look", throwIfNotFound: true);
        m_action_Touch = m_action.FindAction("Touch", throwIfNotFound: true);
        m_action_TouchPosition = m_action.FindAction("TouchPosition", throwIfNotFound: true);
        m_action_TouchLook = m_action.FindAction("TouchLook", throwIfNotFound: true);
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
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // action
    private readonly InputActionMap m_action;
    private IActionActions m_ActionActionsCallbackInterface;
    private readonly InputAction m_action_Move;
    private readonly InputAction m_action_Look;
    private readonly InputAction m_action_Touch;
    private readonly InputAction m_action_TouchPosition;
    private readonly InputAction m_action_TouchLook;
    public struct ActionActions
    {
        private @PlayerPref m_Wrapper;
        public ActionActions(@PlayerPref wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_action_Move;
        public InputAction @Look => m_Wrapper.m_action_Look;
        public InputAction @Touch => m_Wrapper.m_action_Touch;
        public InputAction @TouchPosition => m_Wrapper.m_action_TouchPosition;
        public InputAction @TouchLook => m_Wrapper.m_action_TouchLook;
        public InputActionMap Get() { return m_Wrapper.m_action; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionActions set) { return set.Get(); }
        public void SetCallbacks(IActionActions instance)
        {
            if (m_Wrapper.m_ActionActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnLook;
                @Touch.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnTouch;
                @Touch.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnTouch;
                @Touch.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnTouch;
                @TouchPosition.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnTouchPosition;
                @TouchPosition.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnTouchPosition;
                @TouchLook.started -= m_Wrapper.m_ActionActionsCallbackInterface.OnTouchLook;
                @TouchLook.performed -= m_Wrapper.m_ActionActionsCallbackInterface.OnTouchLook;
                @TouchLook.canceled -= m_Wrapper.m_ActionActionsCallbackInterface.OnTouchLook;
            }
            m_Wrapper.m_ActionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @Touch.started += instance.OnTouch;
                @Touch.performed += instance.OnTouch;
                @Touch.canceled += instance.OnTouch;
                @TouchPosition.started += instance.OnTouchPosition;
                @TouchPosition.performed += instance.OnTouchPosition;
                @TouchPosition.canceled += instance.OnTouchPosition;
                @TouchLook.started += instance.OnTouchLook;
                @TouchLook.performed += instance.OnTouchLook;
                @TouchLook.canceled += instance.OnTouchLook;
            }
        }
    }
    public ActionActions @action => new ActionActions(this);
    public interface IActionActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnTouch(InputAction.CallbackContext context);
        void OnTouchPosition(InputAction.CallbackContext context);
        void OnTouchLook(InputAction.CallbackContext context);
    }
}
