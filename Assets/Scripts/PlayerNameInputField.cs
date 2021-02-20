using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InputField))]
public class PlayerNameInputField : MonoBehaviour
{
    #region Private Constants

    // Store the PlayerPref Key to avoid typos
    private const string PlayerNamePrefKey = "PlayerName";

    #endregion

    #region MonoBehaviour Callbacks

    // MonoBehaviour method called on GameObject by Unity during initialization phase.
    void Start()
    {
        string defaultName = string.Empty;
        InputField inputField = GetComponent<InputField>();
        if (inputField != null)
        {
            if (PlayerPrefs.HasKey(PlayerNamePrefKey))
            {
                defaultName = PlayerPrefs.GetString(PlayerNamePrefKey);
                inputField.text = defaultName;
            }
        }

        PhotonNetwork.NickName = defaultName;
    }
    #endregion

    #region Public Methods

    // Sets the name of the player, and save it in the PlayerPrefs for future sessions.
    // <param name="value">The name of the Player</param>

    public void SetPlayerName(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            Debug.LogError("Player Name is Null or Empty");
            return;
        }

        PhotonNetwork.NickName = value;

        PlayerPrefs.SetString(PlayerNamePrefKey, value);
    }
    #endregion
    // Update is called once per frame
    void Update()
    {
        
    }
}
