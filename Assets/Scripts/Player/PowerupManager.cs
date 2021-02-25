using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.InputSystem;

public class PowerupManager : MonoBehaviourPun
{
    #region Private Serializable Fields

    [SerializeField] private Powerup startPowerup;
    [SerializeField] private Vector3 powerupSpawnOffset;
    [SerializeField] private int numberOfRings;
    [SerializeField] private int ringPointMultiplier;
    [SerializeField] private float ringSpread;
    [SerializeField] private bool unlimitedPowerups;
    [SerializeField] private Vector3 raycastOriginOffset;

    #endregion

    #region Private Fields

    private Powerup currentPowerup;

    private Controls controls;

    private new Rigidbody rigidbody;

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

        rigidbody = GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerupDisplay"))
        {
            PowerupDisplay displayScript = other.GetComponent<PowerupDisplay>();

            if (displayScript != null)
            {
                currentPowerup = displayScript.powerup;
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
            // Networked instantiation
            GameObject newPowerup = PhotonNetwork.Instantiate(currentPowerup.obj.name, transform.position + transform.TransformDirection(powerupSpawnOffset), transform.rotation, 0);

            switch (currentPowerup.name)
            {
                case "Homing Missile":
                    newPowerup.GetComponent<HomingMissile>().SetTarget(FindTarget());

                    newPowerup.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, transform.InverseTransformDirection(rigidbody.velocity).z);
                    Debug.Log(newPowerup.GetComponent<Rigidbody>().velocity);
                    break;
                case "Remote Missile":
                    newPowerup.GetComponent<Rigidbody>().velocity = rigidbody.velocity;
                    break;
                case "Boost":
                    newPowerup.GetComponent<Boost>().SetPlayer(transform);
                    break;

            }

            if (!unlimitedPowerups)
            {
                currentPowerup = null;
            }
        }
    }

    private Transform FindTarget ()
    {
        RaycastHit hit;

        for (int i = 0; i < numberOfRings; i++)
        {
            int raysInRing = i * ringPointMultiplier;

            for (int j = 0; j < raysInRing; j++)
            {
                float angleInDegrees = (float)j / raysInRing * 360;
                float angleInRadians = angleInDegrees * Mathf.PI / 180;

                Vector3 castDirection = transform.TransformDirection(new Vector3(
                    (float)(Vector3.forward.x + i * ringSpread * Mathf.Sin(angleInRadians)),
                    (float)(Vector3.forward.y + i * ringSpread * Mathf.Cos(angleInRadians)),
                    Vector3.forward.z
                ));

                if (Physics.Raycast(transform.position + transform.TransformDirection(raycastOriginOffset), castDirection, out hit, Mathf.Infinity))
                {
                    if (hit.transform.tag == "Player")
                    {
                        Debug.DrawRay(transform.position, castDirection * hit.distance, Color.red, 1);

                        return hit.transform;
                    } else
                    {
                        Debug.DrawRay(transform.position, castDirection * hit.distance, Color.yellow, 1);
                    }
                }
                else
                {
                    Debug.DrawRay(transform.position, castDirection * 1000, Color.white, 1);
                }
            }
        }

        return null;
    }

    #endregion
}
