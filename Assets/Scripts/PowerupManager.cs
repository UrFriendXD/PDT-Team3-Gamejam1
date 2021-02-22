using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PowerupManager : MonoBehaviour
{
    #region Private Serializable Fields

    [SerializeField] private GameObject startPowerup;
    [SerializeField] private Vector3 instantiationOffset;

    #endregion

    #region Private Fields

    private GameObject currentPowerup;

    private Controls controls;

    #endregion

    #region MonoBehaviour CallBacks

    private void Awake()
    {
        controls = new Controls();
    }

    private void Start()
    {
        currentPowerup = startPowerup;

        controls.PlaneFlight.Fire.performed += ctx => Fire();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PowerupDisplay")
        {
            PowerupDisplay displayScript = other.GetComponent<PowerupDisplay>();

            if (displayScript != null)
            {
                currentPowerup = displayScript.powerup.obj;
            }
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

    #region Private Methods

    void Fire()
    {
        if (currentPowerup != null)
        {
            GameObject bullet = Instantiate(
                currentPowerup,
                transform.position,
                transform.rotation
            );

            currentPowerup = null;
        }
    }

    #endregion
}
