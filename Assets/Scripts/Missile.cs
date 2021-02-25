using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class Missile : MonoBehaviourPun
{
    #region Private Serializable Fields

    [SerializeField] protected GameObject explosion;
    [SerializeField] protected float acceleration;
    [SerializeField] protected float maxSpeed;
    [SerializeField] protected float detonationTime;

    #endregion

    #region Private Fields

    protected new Rigidbody rigidbody;

    #endregion

    #region MonoBehaviour CallBacks

    protected virtual void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        StartCoroutine(Timeout());
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        Detonate();
    }

    #endregion

    #region Private Methods

    protected void Detonate()
    {
        Instantiate(explosion, transform.position, Quaternion.identity);

        // Destroy object on the network
        if (photonView.IsMine)
        {
            PhotonNetwork.Destroy(gameObject);
        }
    }

    #endregion

    #region IEnumerators

    private IEnumerator Timeout()
    {
        yield return new WaitForSeconds(detonationTime);

        Detonate();
    }

    #endregion
}
