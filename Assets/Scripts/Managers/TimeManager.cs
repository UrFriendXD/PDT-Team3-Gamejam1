using System;
using System.Collections.Generic;
using System.Linq;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviourPunCallbacks
{
    #region Public Fields

    public PlayerTimer playerTimer;

    #endregion

    #region Private Fields

    [SerializeField] private GameObject postGameMenu;
    [SerializeField] private List<PlayerTimePanel> _timePanels = new List<PlayerTimePanel>();
    [SerializeField] private GameObject lobbyButton;

    private Dictionary<string, float> playerTimes = new Dictionary<string, float>();

    private const string FinishedTime = "FinishedTime";
    private const string PlayerFinishedLevel = "PlayerFinishedLevel";
    
    private bool AllPlayersFinishedLevel
    {
        get
        {
            return PhotonNetwork.PlayerList.All(player => player.CustomProperties[FinishedTime] != null);
        }
    }

    #endregion

    #region Photon Callbacks

    public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
    {
        if (!changedProps.ContainsKey(FinishedTime) ) return;

        if ((float) changedProps[FinishedTime] == 0) return;

        if (!playerTimes.ContainsKey(targetPlayer.NickName))
        {
            playerTimes.Add(targetPlayer.NickName, (float) targetPlayer.CustomProperties[FinishedTime]);
        }
        playerTimes = playerTimes.OrderBy(pair => pair.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
        UpdateTimes();

        if (!PhotonNetwork.IsMasterClient) return;

        if (!AllPlayersFinishedLevel) return;
        lobbyButton.SetActive(true);
    }

    #endregion

    #region Public Methods

    public void LocalPlayerFinishedLevel(float time)
    {
        postGameMenu.SetActive(enabled);
        playerTimes.Add(PhotonNetwork.LocalPlayer.NickName, time);
        PhotonNetwork.LocalPlayer.SetCustomProperties(new Hashtable { { FinishedTime, time } });
        GameManager.Instance.DisableLocalPlayer();
    }

    #endregion

    #region Private Methods

    private void UpdateTimes()
    {
        for (var i = 0; i < playerTimes.Count; i++)
        {
            if (!_timePanels[i].gameObject.activeSelf)
            {
                _timePanels[i].gameObject.SetActive(true);
            }
            _timePanels[i].SetPlayersTime(i, playerTimes.ElementAt(i).Key, playerTimes.ElementAt(i).Value);
        }
    }

    #endregion
    
    #region RPCS

    [PunRPC]
    private void RPC_UpdatePlayerTimes(float time)
    {
        UpdateTimes();
    }
    

    #endregion
    // Start is called before the first frame update
    void Start()
    {
    }
    
    

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}