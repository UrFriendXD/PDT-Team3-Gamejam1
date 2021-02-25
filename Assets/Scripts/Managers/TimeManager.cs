using System;
using System.Collections.Generic;
using System.Linq;
using ExitGames.Client.Photon;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviourPunCallbacks
{
    #region Public Fields

    public PlayerTimer playerTimer;

    #endregion

    #region Private Fields

    [SerializeField] private GameObject postGameMenu;
    [SerializeField] private List<PlayerTimePanel> _timePanels = new List<PlayerTimePanel>();
    private List<float> playerTimes = new List<float>();

    private const string FinishedTime = "FinishedTime";

    #endregion

    #region Photon Callbacks

    public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
    {
        if (!changedProps.ContainsKey(FinishedTime)) return;
        
        playerTimes.Add((float) targetPlayer.CustomProperties[FinishedTime]);
        playerTimes = playerTimes.OrderBy(i => i).ToList();
        UpdateTimes(targetPlayer.NickName);
    }

    #endregion

    #region Public Methods

    public void LocalPlayerFinishedLevel(float time)
    {
        postGameMenu.SetActive(enabled);
        photonView.RPC("RPC_SendLocalPlayerTime", RpcTarget.All, time);
        GameManager.Instance.DisableLocalPlayer();
    }

    #endregion

    #region Private Methods

    private void UpdateTimes(string nickname)
    {
        for (var i = 0; i < playerTimes.Count; i++)
        {
            if (!_timePanels[i].gameObject.activeSelf)
            {
                _timePanels[i].gameObject.SetActive(true);
            }
            _timePanels[i].SetPlayersTime(i, nickname, playerTimes[i]);
        }
    }

    #endregion
    
    #region RPCS

    [PunRPC]
    private void RPC_SendLocalPlayerTime(float time)
    {
        PhotonNetwork.LocalPlayer.SetCustomProperties(new Hashtable { { FinishedTime, time } });
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