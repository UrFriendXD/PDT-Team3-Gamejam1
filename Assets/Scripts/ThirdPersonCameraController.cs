using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private float frontOffset;
    [SerializeField] private float upOffset;
    [SerializeField] private float pitchFollowFactor;

    private bool isFollowing;

    void LateUpdate()
    {
        if (isFollowing)
        {

            float targetRotationRadians = target.rotation.eulerAngles.y * Mathf.PI / 180;

            float normalisedTargetPitch = target.rotation.eulerAngles.x > 180 ? target.rotation.eulerAngles.x - 360 : target.rotation.eulerAngles.x;

            Debug.Log(normalisedTargetPitch);

            transform.position = new Vector3(
                target.position.x + frontOffset * Mathf.Sin(targetRotationRadians),
                target.position.y + upOffset + normalisedTargetPitch * pitchFollowFactor,
                target.position.z + frontOffset * Mathf.Cos(targetRotationRadians)
            );

            transform.rotation = Quaternion.LookRotation(target.position - transform.position);
        }
    }

    public void OnStartFollowing(Transform _target)
    {
        isFollowing = true;
        target = _target;
    }
}
