using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoostZone : MonoBehaviour
{
    [SerializeField] float boostAcceleration;

    private List<Transform> players = new List<Transform>();
    private List<Rigidbody> rigidbodies = new List<Rigidbody>();

    private void Update()
    {
        for (int i = 0; i < players.Count; i++)
        {
            rigidbodies[i].AddForce(players[i].forward * boostAcceleration * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            players.Add(other.transform);

            rigidbodies.Add(other.GetComponent<Rigidbody>());
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            players.Remove(other.transform);

            rigidbodies.Remove(other.GetComponent<Rigidbody>());
        }
    }
}
