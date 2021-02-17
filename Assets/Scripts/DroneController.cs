using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    [SerializeField] private float thrustMultiplier;
    [SerializeField] private float yawSpeed;
    [SerializeField] private float maxTilt;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float thrust = Input.GetAxis("Vertical");

        rb.AddForce(transform.up * thrust * thrustMultiplier);

        transform.rotation = Quaternion.Euler(
            Input.GetAxis("RightVertical") * maxTilt * -1,
            transform.rotation.eulerAngles.y + Input.GetAxis("Horizontal") * yawSpeed,
            Input.GetAxis("RightHorizontal") * maxTilt * -1
        );
    }
}
