using Photon.Pun;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviourPunCallbacks
{
    //[SerializeField] private float startDelay;
    [SerializeField] private float startDelayTimer = 3.0f;
    [SerializeField] private TextMeshProUGUI timerText;

    private bool _startInitialCountdown = false;
    private bool _canStartGame = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartingCountdown();
    }

    private void StartingCountdown()
    {
        // if (_startInitialCountdown)
        // {
        //     startDelayTimer -= Time.deltaTime;
        //     string tempTimer = $"{startDelayTimer:00}";
        //     timerText.text = tempTimer;
        //     
        //     if (startDelayTimer < 0f)
        //     {
        //         _startInitialCountdown = false;
        //         timerText.gameObject.SetActive(false);
        //         
        //         // Call in game manager to activate all players
        //         GameManager.Instance.StartGame();
        //     }
        // }
    }

    public void AllPlayersJoined()
    {
        _startInitialCountdown = true;
    }
}