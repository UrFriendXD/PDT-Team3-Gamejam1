// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

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
            ""name"": ""PlaneFlight"",
            ""id"": ""af5efe6a-8e60-4c5a-a46b-7610425d7295"",
            ""actions"": [
                {
                    ""name"": ""Throttle"",
                    ""type"": ""PassThrough"",
                    ""id"": ""bd56f4ce-3c56-43d5-94dc-667616302347"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Yaw"",
                    ""type"": ""PassThrough"",
                    ""id"": ""17f7d068-bd45-429c-b520-d5857266f1d6"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pitch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6c6311f0-5a55-445d-b63f-931f045604ed"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Strafe"",
                    ""type"": ""PassThrough"",
                    ""id"": ""cbe26493-8699-4380-a96b-6209e2ec7d4c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ReverseThrottle"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8a8a5568-a15e-40b3-a729-956995554682"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""95875b57-7b83-4370-ae0d-8bafd51af123"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0e97928-f4fc-44ce-8435-6b13f2dddc1a"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c35702b7-a6d7-43ab-81ed-a3a64e882886"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8cc2885d-5c9c-4131-9a9c-7e0ef62e4494"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6a46055-f950-4b53-bd00-6df4093b7c60"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ReverseThrottle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlaneFlight
        m_PlaneFlight = asset.FindActionMap("PlaneFlight", throwIfNotFound: true);
        m_PlaneFlight_Throttle = m_PlaneFlight.FindAction("Throttle", throwIfNotFound: true);
        m_PlaneFlight_Yaw = m_PlaneFlight.FindAction("Yaw", throwIfNotFound: true);
        m_PlaneFlight_Pitch = m_PlaneFlight.FindAction("Pitch", throwIfNotFound: true);
        m_PlaneFlight_Strafe = m_PlaneFlight.FindAction("Strafe", throwIfNotFound: true);
        m_PlaneFlight_ReverseThrottle = m_PlaneFlight.FindAction("ReverseThrottle", throwIfNotFound: true);
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

    // PlaneFlight
    private readonly InputActionMap m_PlaneFlight;
    private IPlaneFlightActions m_PlaneFlightActionsCallbackInterface;
    private readonly InputAction m_PlaneFlight_Throttle;
    private readonly InputAction m_PlaneFlight_Yaw;
    private readonly InputAction m_PlaneFlight_Pitch;
    private readonly InputAction m_PlaneFlight_Strafe;
    private readonly InputAction m_PlaneFlight_ReverseThrottle;
    public struct PlaneFlightActions
    {
        private @Controls m_Wrapper;
        public PlaneFlightActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throttle => m_Wrapper.m_PlaneFlight_Throttle;
        public InputAction @Yaw => m_Wrapper.m_PlaneFlight_Yaw;
        public InputAction @Pitch => m_Wrapper.m_PlaneFlight_Pitch;
        public InputAction @Strafe => m_Wrapper.m_PlaneFlight_Strafe;
        public InputAction @ReverseThrottle => m_Wrapper.m_PlaneFlight_ReverseThrottle;
        public InputActionMap Get() { return m_Wrapper.m_PlaneFlight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlaneFlightActions set) { return set.Get(); }
        public void SetCallbacks(IPlaneFlightActions instance)
        {
            if (m_Wrapper.m_PlaneFlightActionsCallbackInterface != null)
            {
                @Throttle.started -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnThrottle;
                @Throttle.performed -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnThrottle;
                @Throttle.canceled -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnThrottle;
                @Yaw.started -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnYaw;
                @Yaw.performed -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnYaw;
                @Yaw.canceled -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnYaw;
                @Pitch.started -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnPitch;
                @Pitch.performed -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnPitch;
                @Pitch.canceled -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnPitch;
                @Strafe.started -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnStrafe;
                @Strafe.performed -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnStrafe;
                @Strafe.canceled -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnStrafe;
                @ReverseThrottle.started -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnReverseThrottle;
                @ReverseThrottle.performed -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnReverseThrottle;
                @ReverseThrottle.canceled -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnReverseThrottle;
            }
            m_Wrapper.m_PlaneFlightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Throttle.started += instance.OnThrottle;
                @Throttle.performed += instance.OnThrottle;
                @Throttle.canceled += instance.OnThrottle;
                @Yaw.started += instance.OnYaw;
                @Yaw.performed += instance.OnYaw;
                @Yaw.canceled += instance.OnYaw;
                @Pitch.started += instance.OnPitch;
                @Pitch.performed += instance.OnPitch;
                @Pitch.canceled += instance.OnPitch;
                @Strafe.started += instance.OnStrafe;
                @Strafe.performed += instance.OnStrafe;
                @Strafe.canceled += instance.OnStrafe;
                @ReverseThrottle.started += instance.OnReverseThrottle;
                @ReverseThrottle.performed += instance.OnReverseThrottle;
                @ReverseThrottle.canceled += instance.OnReverseThrottle;
            }
        }
    }
    public PlaneFlightActions @PlaneFlight => new PlaneFlightActions(this);
    public interface IPlaneFlightActions
    {
        void OnThrottle(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnPitch(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
        void OnReverseThrottle(InputAction.CallbackContext context);
    }
}
