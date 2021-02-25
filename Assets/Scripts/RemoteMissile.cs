using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

public class RemoteMissile : Missile
{
    #region Private Fields

    private Controls controls;

    #endregion

    #region MonoBehaviour CallBacks

    private void Awake()
    {
        controls = new Controls();
    }

    protected override void Start()
    {
        base.Start();

        controls.PlaneFlight.Fire.performed += ctx => Detonate();
    }

    private void Update()
    {
        if (rigidbody.velocity.magnitude < maxSpeed)
        {
            rigidbody.AddForce(transform.forward * acceleration * Time.deltaTime);
        }
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    #endregion
}
