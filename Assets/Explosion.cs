using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    #region Private Serializable Fields

    [SerializeField] private float maxSize;
    [SerializeField] private float attackTime;
    [SerializeField] private float sustainTime;
    [SerializeField] private float releaseTime;
    [SerializeField] private float slowdown;

    #endregion

    #region Private Fields

    private new SphereCollider collider;

    #endregion

    #region MonoBehaviour CallBacks

    private void Start()
    {
        collider = GetComponent<SphereCollider>();

        StartCoroutine(Explode());
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            Rigidbody playerRigidbody = other.attachedRigidbody;

            playerRigidbody.AddForce(playerRigidbody.velocity * -1 * slowdown);
        }
    }

    #endregion

    #region Private IEnumerators

    private IEnumerator Explode()
    {
        float timer = 0;

        // Increase size from zero to maxSize
        while (timer < attackTime)
        {
            transform.localScale = Vector3.one * maxSize * timer / attackTime;

            timer += Time.deltaTime;

            yield return null;
        }

        transform.localScale = Vector3.one * maxSize;

        // Hold maxSize
        yield return new WaitForSeconds(sustainTime);

        collider.enabled = false;

        timer = 0;

        // Decrease size from maxSize to zero
        while (timer < releaseTime)
        {
            transform.localScale = Vector3.one * maxSize * (1 - timer / releaseTime);

            timer += Time.deltaTime;

            yield return null;
        }

        Destroy(gameObject);
    }

    #endregion
}
