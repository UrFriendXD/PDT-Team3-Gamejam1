using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlaneController : MonoBehaviourPunCallbacks
{
    [SerializeField] private float thrustMultiplier;
    [SerializeField] private float yawSpeed;
    [SerializeField] private float maxTurn;
    [SerializeField] private bool invertPitch;

    Controls controls;

    private float throttle;
    private Vector2 strafe;
    private float yaw;
    private float pitch;

    private Rigidbody rb;

    private void Awake()
    {
        controls = new Controls();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        controls.PlaneFlight.Throttle.performed += ctx => throttle = ctx.ReadValue<float>();
        controls.PlaneFlight.Throttle.canceled += ctx => throttle = 0;

        controls.PlaneFlight.Strafe.performed += ctx => strafe = ctx.ReadValue<Vector2>();
        controls.PlaneFlight.Strafe.canceled += ctx => strafe = Vector2.zero;

        controls.PlaneFlight.Yaw.performed += ctx => yaw = ctx.ReadValue<float>();
        controls.PlaneFlight.Yaw.canceled += ctx => yaw = 0;

        controls.PlaneFlight.Pitch.performed += ctx => pitch = ctx.ReadValue<float>();
        controls.PlaneFlight.Pitch.canceled += ctx => pitch = 0;

        controls.PlaneFlight.Pitch.AddBinding("<Mouse>/position/y")
            .WithProcessor("normalize(" +
                "min=0," +
                "max=" + Screen.height + "," +
                "zero=" + Mathf.Floor(Screen.height / 2) +
            ")")
            .WithGroup("KB&M");

        controls.PlaneFlight.Yaw.AddBinding("<Mouse>/position/x")
            .WithProcessor("normalize(" +
                "min=0," +
                "max=" + Screen.width + "," +
                "zero=" + Mathf.Floor(Screen.width / 2) +
            ")")
            .WithGroup("KB&M");
    }

    void Update()
    {
        rb.AddForce(transform.forward * throttle * thrustMultiplier);
        rb.AddForce(transform.up * strafe.y * thrustMultiplier);
        rb.AddForce(transform.right * strafe.x * thrustMultiplier);

        transform.rotation = Quaternion.Euler(
            pitch * maxTurn * (invertPitch ? -1 : 1),
            transform.rotation.eulerAngles.y + yaw * yawSpeed,
            yaw * maxTurn * -1
        );
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }
}
