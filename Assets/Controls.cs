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
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""95875b57-7b83-4370-ae0d-8bafd51af123"",
                    ""path"": ""<Gamepad>/rightStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Yaw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Triggers"",
                    ""id"": ""433413f4-e549-42ff-b749-80f0f44b730d"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""0c71f3f8-8462-447d-a7ad-7a3333f62a91"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""03962607-2a59-42d6-91d5-dbca9378befd"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""a368b660-48e5-4ff4-a003-2a591c513e0c"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Throttle"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""2aaa4dda-3a79-44f4-b0e7-46a864e585fd"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9b2f03c6-b674-4f28-9021-d4db9218f4d0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c35702b7-a6d7-43ab-81ed-a3a64e882886"",
                    ""path"": ""<Gamepad>/rightStick/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
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
                    ""groups"": ""GamePad"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""4da4679b-a908-4059-adf3-c0f6e4712772"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Strafe"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""335828b0-faf6-48de-943f-efdc89fa4b9d"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""0f689d3e-4727-45c6-999b-d3d408752c51"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""15fae541-8f87-4720-aa68-1570b5584ec9"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd5a67ee-bfcf-4a7e-9db0-75d90e7b95b5"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Strafe"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""KB&M"",
            ""bindingGroup"": ""KB&M"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlaneFlight
        m_PlaneFlight = asset.FindActionMap("PlaneFlight", throwIfNotFound: true);
        m_PlaneFlight_Throttle = m_PlaneFlight.FindAction("Throttle", throwIfNotFound: true);
        m_PlaneFlight_Yaw = m_PlaneFlight.FindAction("Yaw", throwIfNotFound: true);
        m_PlaneFlight_Pitch = m_PlaneFlight.FindAction("Pitch", throwIfNotFound: true);
        m_PlaneFlight_Strafe = m_PlaneFlight.FindAction("Strafe", throwIfNotFound: true);
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
    public struct PlaneFlightActions
    {
        private @Controls m_Wrapper;
        public PlaneFlightActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throttle => m_Wrapper.m_PlaneFlight_Throttle;
        public InputAction @Yaw => m_Wrapper.m_PlaneFlight_Yaw;
        public InputAction @Pitch => m_Wrapper.m_PlaneFlight_Pitch;
        public InputAction @Strafe => m_Wrapper.m_PlaneFlight_Strafe;
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
            }
        }
    }
    public PlaneFlightActions @PlaneFlight => new PlaneFlightActions(this);
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KB&M");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    public interface IPlaneFlightActions
    {
        void OnThrottle(InputAction.CallbackContext context);
        void OnYaw(InputAction.CallbackContext context);
        void OnPitch(InputAction.CallbackContext context);
        void OnStrafe(InputAction.CallbackContext context);
    }
}
