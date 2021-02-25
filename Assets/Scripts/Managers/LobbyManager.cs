using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LobbyManager : MonoBehaviourPunCallbacks
{
    #region Public Fields

    [Tooltip("The start game button")]
    public GameObject startGameButton;

    #endregion

    #region Private fields
    

    [SerializeField] private TextMeshProUGUI playerCountDisplay;
    [SerializeField] private int nextSceneIndex;

    private int playerCount;
    private int roomSize;

    #endregion
    
    #region Photon Callbacks

    /// <summary>
    /// Called when the local player left the room. We need to load the launcher scene.
    /// </summary>
    public override void OnLeftRoom()
    {
        SceneManager.LoadScene(0);
    }

    public override void OnPlayerEnteredRoom(Player newPlayer)
    {
        Debug.LogFormat("OnPlayerEnteredRoom() {0}", newPlayer.NickName); // not seen if you're the player connecting

        if (PhotonNetwork.IsMasterClient)
        {
            Debug.LogFormat("OnPlayerEnteredRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient); // Called before OnPlayerLeftRoom
        }
        UpdatePlayerCount();

    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.LogFormat("OnPlayerLeftRoom() {0}", otherPlayer.NickName); // seen when other disconnects

        if (PhotonNetwork.IsMasterClient)
        {
            Debug.LogFormat("OnPlayerEnteredRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient); // Called before OnPlayerLeftRoom
            startGameButton.gameObject.SetActive(true);
        }
        UpdatePlayerCount();
    }

    #endregion

    #region Public Methods

    public void LeaveRoom()
    {
        Debug.Log("leaving room");
        PhotonNetwork.LeaveRoom();
    }

    #endregion

    #region Private Methods

    private void Start()
    {

        UpdatePlayerCount();
        
        if (!PhotonNetwork.IsMasterClient)
        {
            startGameButton.SetActive(false);
        }
    }

    // Updates player count UI
    private void UpdatePlayerCount()
    {
        playerCount = PhotonNetwork.PlayerList.Length;
        roomSize = PhotonNetwork.CurrentRoom.MaxPlayers;
        playerCountDisplay.text = playerCount + "/" + roomSize;
    }

    public void LoadNextScene()
    {
        if (!PhotonNetwork.IsMasterClient)
        {
            Debug.LogError("PhotonNetwork : Trying to Load a level but we are not the master Client");
            return;
        }
        Debug.LogFormat("PhotonNetwork : Loading Level : {0}", PhotonNetwork.CurrentRoom.PlayerCount);
        // Change nextLevelSceneIndex later on to the level select stuff in inspector or code
        PhotonNetwork.CurrentRoom.IsOpen = false;
        PhotonNetwork.LoadLevel(nextSceneIndex);
    }

    #endregion
}