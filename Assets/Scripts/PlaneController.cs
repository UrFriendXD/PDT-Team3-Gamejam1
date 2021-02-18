using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    [SerializeField] private float thrustMultiplier;
    [SerializeField] private float yawSpeed;
    [SerializeField] private float maxTurn;
    [SerializeField] private bool invertPitch;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.AddForce(transform.forward * Input.GetAxis("Vertical") * thrustMultiplier);
        rb.AddForce(transform.right * Input.GetAxis("Horizontal") * thrustMultiplier);

        transform.rotation = Quaternion.Euler(
            Input.GetAxis("RightVertical") * maxTurn * (invertPitch ? -1 : 1),
            transform.rotation.eulerAngles.y + Input.GetAxis("RightHorizontal") * yawSpeed,
            Input.GetAxis("RightHorizontal") * maxTurn * -1
        );
    }
}
