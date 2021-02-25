using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class Boost : MonoBehaviourPun
{
    #region Serialized Private Fields

    [SerializeField] private float boostDuration;
    [SerializeField] private float boostAcceleration;

    #endregion

    #region Private Fields

    private Transform player;
    private Rigidbody playerRigidbody;

    #endregion

    #region Private Methods

    public void SetPlayer(Transform player)
    {
        this.player = player;
        playerRigidbody = player.GetComponent<Rigidbody>();

        StartCoroutine(BoostPlayer());
    }

    #endregion

    #region IEnumerators

    private IEnumerator BoostPlayer()
    {
        float timer = 0;

        while (timer < boostDuration)
        {
            timer += Time.deltaTime;

            playerRigidbody.AddForce(player.forward * boostAcceleration * Time.deltaTime);

            yield return null;
        }

        // Destroy object on the network
        if (photonView.IsMine)
        {
            PhotonNetwork.Destroy(gameObject);
        }
    }

    #endregion
}
