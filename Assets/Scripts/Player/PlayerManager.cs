using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using Photon.Pun;
using UnityEngine;

public class PlayerManager : MonoBehaviourPunCallbacks, IPunObservable
{
    #region Private Fields
    private VehicleController playerController;
    private PowerupManager _powerupManager;

    private bool _isFiring;
    private bool _isPaused;
    
    #endregion

    #region Public Fields

    [Tooltip("The current Health of our Player")]
    public float health = 1f;
    
    [Tooltip("The local player instance. Use this to know if the local player is represented in the Scene")]
    public static GameObject LocalPlayerInstance;

    [Tooltip("The Player's UI GameObject Prefab")] [SerializeField]
    private GameObject PlayerUIPrefab;

    #endregion

    #region MonoBehaviour Callbacks

    private void Awake()
    {
        // #Important
        // Use in GameManager.cs: we keep track of the localPlayerInstance to prevent instantiation when levels are synchronized
        if (photonView.IsMine)
        {
            LocalPlayerInstance = gameObject;
        }

        playerController = GetComponent<PlaneController>();
        _powerupManager = GetComponent<PowerupManager>();

        // #Critical
        // We flag as don't destroy on load so that instance survives level synchronization, thus giving a seamless experience when levels load.
        // DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        playerController.enabled = false;
        _powerupManager.enabled = false;

        if (!photonView.IsMine)
        {
            GetComponentInChildren<Canvas>().gameObject.SetActive(false);
        }

        // Should move to it's own class :3
        ThirdPersonCameraController cameraController = Camera.main.GetComponent<ThirdPersonCameraController>();
        if (cameraController != null)
        {
            if (photonView.IsMine)
            {
                cameraController.OnStartFollowing(gameObject.transform);
            }
        }
        else
        {
            Debug.LogError("<Color=Red><a>Missing</a></Color> CameraWork Component on playerPrefab.", this);
        }

        if (PlayerUIPrefab != null)
        {
            GameObject uiGo = Instantiate(PlayerUIPrefab);
            uiGo.SendMessage("SetTarget", this, SendMessageOptions.RequireReceiver);
        }
        else
        {
            Debug.LogWarning("<Color=Red><a>Missing</a></Color> PlayerUiPrefab reference on player Prefab.", this);
        }

        // Register a method to call CalledOnLevelWasLoaded.
        UnityEngine.SceneManagement.SceneManager.sceneLoaded += OnSceneLoaded;

    }

    private void Update()
    {
        if (photonView.IsMine)
        {
        }
    }

    // Affect Health of the Player if the collider is a beam
    // Note: when jumping and firing at the same, you'll find that the player's own beam intersects with itself
    // One could move the collider further away to prevent this or check if the beam belongs to the player.
    private void OnTriggerEnter(Collider other)
    {
        if (!photonView.IsMine)
        {
            return;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        // we don't do anything if we are not the local player
        if (!photonView.IsMine)
        {
            return;
        }
    }
    
    private void CalledOnLevelWasLoaded()
    {
        if (!Physics.Raycast(transform.position, -Vector3.up, 5f))
        {
            transform.position = new Vector3(0f, 5f, 0f);
        }

        GameObject uiGo = Instantiate(PlayerUIPrefab);
        uiGo.SendMessage("SetTarget", this, SendMessageOptions.RequireReceiver);
    }
    
    public override void OnDisable()
    {
        // Always call the base to remove callbacks
        base.OnDisable();
        UnityEngine.SceneManagement.SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    
    #endregion

    #region Private Methods
    
    private void OnSceneLoaded(UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode loadingMode)
    {
        CalledOnLevelWasLoaded();
    }

    private void OnPause()
    {
        if (_isPaused)
        {
            _isPaused = false;
            Cursor.lockState = CursorLockMode.Confined;
        }
        else
        {
            _isPaused = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    #endregion

    #region Public Methods

    // public void StartGame()
    // {
    //     playerController.enabled = true;
    //     _powerupManager.enabled = true;
    // }

    #endregion

    #region IPunObservable implemetation

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        // Kept here incase we need it for future use
        /*if (stream.IsWriting)
        {
            // We own this player: send the others our data
            stream.SendNext(_isFiring);
            stream.SendNext(health);
        }
        else
        {
            // Network player, receive data
            _isFiring = (bool) stream.ReceiveNext();
            health = (float) stream.ReceiveNext();
        }*/
    }

    #endregion
    
}