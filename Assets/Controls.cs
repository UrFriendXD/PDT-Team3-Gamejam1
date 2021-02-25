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
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""49beb05b-1169-4c52-aba4-e1bc00c52c67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""9f7af6eb-8300-44ab-a292-ed635a18323b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Air Brakes"",
                    ""type"": ""Button"",
                    ""id"": ""dcc4ea29-2af6-4e4a-b0a0-da03c787e01f"",
                    ""expectedControlType"": ""Button"",
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
                    ""name"": """",
                    ""id"": ""71b87c98-199b-4669-9115-7cc7cc2c09b0"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Throttle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f88c113-3f72-4e36-9041-3adca92c5513"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
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
                },
                {
                    ""name"": """",
                    ""id"": ""68477295-cabc-4f1e-a830-a093500b7bec"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b14c4331-4c33-4557-87f4-75d99a858b96"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a50ac3b7-b9a1-4ac0-aeb0-2c47ceccb655"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e0bf3e3-d121-4680-80bb-66261558afda"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""929f3328-de75-4b68-ba5f-30b1e1b7de99"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Air Brakes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bcfbffc2-e51c-45b1-83a6-c1bf076254cb"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB&M"",
                    ""action"": ""Air Brakes"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
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
        m_PlaneFlight_Pause = m_PlaneFlight.FindAction("Pause", throwIfNotFound: true);
        m_PlaneFlight_Fire = m_PlaneFlight.FindAction("Fire", throwIfNotFound: true);
        m_PlaneFlight_AirBrakes = m_PlaneFlight.FindAction("Air Brakes", throwIfNotFound: true);
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
    private readonly InputAction m_PlaneFlight_Pause;
    private readonly InputAction m_PlaneFlight_Fire;
    private readonly InputAction m_PlaneFlight_AirBrakes;
    public struct PlaneFlightActions
    {
        private @Controls m_Wrapper;
        public PlaneFlightActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Throttle => m_Wrapper.m_PlaneFlight_Throttle;
        public InputAction @Yaw => m_Wrapper.m_PlaneFlight_Yaw;
        public InputAction @Pitch => m_Wrapper.m_PlaneFlight_Pitch;
        public InputAction @Strafe => m_Wrapper.m_PlaneFlight_Strafe;
        public InputAction @Pause => m_Wrapper.m_PlaneFlight_Pause;
        public InputAction @Fire => m_Wrapper.m_PlaneFlight_Fire;
        public InputAction @AirBrakes => m_Wrapper.m_PlaneFlight_AirBrakes;
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
                @Pause.started -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnPause;
                @Fire.started -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnFire;
                @AirBrakes.started -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnAirBrakes;
                @AirBrakes.performed -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnAirBrakes;
                @AirBrakes.canceled -= m_Wrapper.m_PlaneFlightActionsCallbackInterface.OnAirBrakes;
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
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @AirBrakes.started += instance.OnAirBrakes;
                @AirBrakes.performed += instance.OnAirBrakes;
                @AirBrakes.canceled += instance.OnAirBrakes;
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
        void OnPause(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnAirBrakes(InputAction.CallbackContext context);
    }
}
