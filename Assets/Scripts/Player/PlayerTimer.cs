using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerTimer : MonoBehaviour
{
    #region Private Serializable Fields

    [SerializeField] private UnityEvent OnEndCountdown;
    [SerializeField] private UnityEvent OnTimerStopped;
    [SerializeField] private CourseManager courseManager;
    [SerializeField] private TextMeshProUGUI countdownText;
    [SerializeField] private int countdownSeconds;
    [SerializeField] private string startMessage;
    [SerializeField] private bool startCountdownOnAwake;

    #endregion

    #region Private Fields

    private float timer;
    private bool timerActive;
    
    private TimeManager _timeManager;

    #endregion

    #region MonoBehaviour CallBacks

    private void Start()
    {
        _timeManager = GetComponentInParent<TimeManager>();
        //courseManager.OnCourseComplete.AddListener(StopTimer);

        if (startCountdownOnAwake)
        {
            StartCountdown();
        }
    }

    private void Update()
    {
        UpdateTimer();
    }

    #endregion

    #region Private Methods

    private void UpdateTimer ()
    {
        if (timerActive)
        {
            timer += Time.deltaTime;
        }
    }

    public void StartCountdown ()
    {
        StartCoroutine(Countdown());
    }

    public void StopTimer ()
    {
        timerActive = false;
        
        _timeManager.LocalPlayerFinishedLevel(timer);
        //OnTimerStopped.Invoke();
    }

    #endregion

    #region IEnumerators

    private IEnumerator Countdown ()
    {
        for (int i = countdownSeconds; i > 0; i--)
        {
            countdownText.text = i.ToString();

            yield return new WaitForSeconds(1);
        }

        countdownText.text = startMessage;

        OnEndCountdown.Invoke();

        timerActive = true;

        yield return new WaitForSeconds(1);

        countdownText.text = "";
    }

    #endregion
}
