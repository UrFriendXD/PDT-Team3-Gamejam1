using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float frontOffset;
    [SerializeField] private float upOffset;

    void Update()
    {
        float targetRotationRadians = target.rotation.eulerAngles.y * Mathf.PI / 180;

        transform.position = new Vector3(
            target.position.x + frontOffset * Mathf.Sin(targetRotationRadians),
            target.position.y + upOffset,
            target.position.z + frontOffset * Mathf.Cos(targetRotationRadians)
        );

        transform.rotation = Quaternion.LookRotation(target.position - transform.position);
    }
}
