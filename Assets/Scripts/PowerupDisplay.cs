using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupDisplay : MonoBehaviour
{
    #region Private Fields

    private Renderer rend;

    #endregion

    #region Public Fields

    public Powerup powerup;

    #endregion

    #region MonoBehaviour CallBacks

    void Start()
    {
        rend = GetComponent<Renderer>();

        rend.material.SetColor("_Color", powerup.color);
    }

    #endregion
}
