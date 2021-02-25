using System.Linq;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.SceneManagement;
using Hashtable = ExitGames.Client.Photon.Hashtable;

public class GameManager : MonoBehaviourPunCallbacks
{
    #region Private Fields

    // Property that goes through every player checks if they are ready and returns true if all players are ready
    private bool AllPlayersReady
    {
        get
        {
            return PhotonNetwork.PlayerList.All(player => (bool) player.CustomProperties["ReadyToStart"] == true);
        }
    }

    #endregion
    
    #region Public Fields

    public static GameManager Instance { get; private set; }

    [Tooltip("The prefab to use for representing the player")]
    public GameObject playerPrefab;
    
    private ExitGames.Client.Photon.Hashtable _playerCustomProperties = new ExitGames.Client.Photon.Hashtable();
    [SerializeField] private TimeManager _timeManager;
    
    private void Awake()
    {
        if (Instance != null && Instance!= this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

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
            
            //LoadArena();
        }
    }

    public override void OnPlayerLeftRoom(Player otherPlayer)
    {
        Debug.LogFormat("OnPlayerLeftRoom() {0}", otherPlayer.NickName); // seen when other disconnects

        if (PhotonNetwork.IsMasterClient)
        {
            Debug.LogFormat("OnPlayerEnteredRoom IsMasterClient {0}", PhotonNetwork.IsMasterClient); // Called before OnPlayerLeftRoom
            
            //LoadArena();
        }
    }
    
    // When a custom property on a player changes, this gets called. When all players have loaded in, master client starts countdown to everyone
    // Need to use SetCustomProperty() for this function to be called
    public override void OnPlayerPropertiesUpdate(Player targetPlayer, Hashtable changedProps)
    {
        if (!PhotonNetwork.IsMasterClient) return;

        if (changedProps.ContainsKey("ReadyToStart"))
        {
            if (!AllPlayersReady) return;

            Debug.Log("All Players ready");
            photonView.RPC("RPC_StartCountdownTimer", RpcTarget.AllBuffered);
        }

        
        
    }

    #endregion

    #region Public Methods

    public void LeaveRoom()
    {
        Debug.Log("leaving room");
        Cursor.lockState = CursorLockMode.None;
        PhotonNetwork.LeaveRoom();
    }

    public void EnableLocalPlayer()
    {
        PlayerManager.LocalPlayerInstance.GetComponent<PlayerManager>().EnablePlayer();
    }

    public void DisableLocalPlayer()
    {
        PlayerManager.LocalPlayerInstance.GetComponent<PlayerManager>().DisablePlayer();
    }

    public void ReturnToLobby()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonNetwork.LoadLevel("Lobby");
            PhotonNetwork.CurrentRoom.IsOpen = true;
        }
    }

    #endregion

    #region Private Methods

    private void Start()
    {
        if (playerPrefab == null)
        {
            Debug.LogError("<Color=Red><a>Missing</a></Color> playerPrefab Reference. Please set it up in GameObject 'Game Manager'",this);
        }
        else
        {
            if (PlayerManager.LocalPlayerInstance == null)
            {
                Debug.LogFormat("We are Instantiating LocalPlayer from {0}", SceneManager.GetActiveScene().name);
                // we're in a room. spawn a character for the local player. it gets synced by using PhotonNetwork.Instantiate
                // Could change position later so players don't spawn on top of each other
                PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(0f, 5f, 0f), Quaternion.identity);
            }
            else
            {
                Debug.LogFormat("Ignoring scene load for {0}", SceneManagerHelper.ActiveSceneName);
            }
        }

        Cursor.lockState = CursorLockMode.Confined;
    }

    private void Update()
    {
    }

    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode loadingMode)
    {
        // Tells all clients I have loaded
        PhotonNetwork.LocalPlayer.SetCustomProperties(new Hashtable { { "ReadyToStart", true } });
        //Debug.Log(PhotonNetwork.LocalPlayer.CustomProperties["ReadyToStart"]);
    }

    [PunRPC]
    private void RPC_StartCountdownTimer()
    {
        _timeManager.playerTimer.StartCountdown();
    }

    #endregion
}