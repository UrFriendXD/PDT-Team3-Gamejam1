using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class VehicleController : MonoBehaviourPunCallbacks
{
    [SerializeField] protected float thrustMultiplier;
    [SerializeField] protected float yawSpeed;
    [SerializeField] protected float maxPitch;
    [SerializeField] protected float maxRoll;
    [SerializeField] protected bool invertPitch;

    protected virtual void SetupControls()
    {
        
    }

    protected virtual void MovePlayer()
    {
        
    }
    
    protected virtual void RotatePlayer()
    {
        
    }
}
