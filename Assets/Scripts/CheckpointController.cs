using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointController : MonoBehaviour
{
    #region Private Serializable Fields

    [SerializeField] private Color defaultColor;
    [SerializeField] private Color activeColor;

    #endregion

    #region Private Fields

    private Renderer rend;
    private bool active;

    #endregion

    #region Public Fields

    public Action<GameObject> OnCheckpointTriggered;

    #endregion

    #region MonoBehaviour CallBacks

    private void Awake()
    {
        rend = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (active && OnCheckpointTriggered != null)
        {
            OnCheckpointTriggered(other.gameObject);
        }
    }

    #endregion

    #region Public Methods

    public void SetActive (bool active)
    {
        this.active = active;

        rend.material.SetColor("_Color", active ? activeColor : defaultColor);
    }

    #endregion
}
