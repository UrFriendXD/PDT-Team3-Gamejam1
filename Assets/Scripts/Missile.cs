using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Missile : MonoBehaviour
{
    #region Private Serializable Fields

    [SerializeField] private float speed;

    #endregion

    #region Private Fields

    private Controls controls;

    #endregion

    #region MonoBehaviour CallBacks

    private void Awake()
    {
        controls = new Controls();
    }

    private void Start()
    {
        controls.PlaneFlight.Fire.performed += ctx => Detonate();
    }

    private void Update()
    {
        transform.Translate(transform.forward * (speed * Time.deltaTime), Space.World);
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

    #region Private Methods

    private void Detonate()
    {
        Destroy(gameObject);
    }

    #endregion
}
