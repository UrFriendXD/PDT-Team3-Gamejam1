using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

public class HomingMissile : Missile
{
    #region Private Serializable Fields

    [SerializeField] private float trackingSpeed;

    #endregion

    #region Private Fields

    private Transform target;

    #endregion

    #region MonoBehaviour CallBacks

    private void Update()
    {
        if (target != null)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation,
                Quaternion.LookRotation(target.position - transform.position),
                trackingSpeed * Time.deltaTime
            );
        }

        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(transform.forward * acceleration * Time.deltaTime);
        }
    }

    #endregion

    #region Public Methods

    public void SetTarget(Transform target)
    {
        this.target = target;
    }

    #endregion
}
