using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CourseManager : MonoBehaviour
{
    #region Private Serializable Fields

    [SerializeField] private CheckpointController[] checkpoints;
    [SerializeField] public UnityEvent OnCourseComplete;

    #endregion

    #region Private Fields

    private int activeID = 0;

    #endregion

    #region MonoBehaviour CallBacks

    void Start()
    {
        for (int i = 0; i < checkpoints.Length; i++)
        {
            CheckpointController checkpoint = checkpoints[i];
            
            checkpoint.OnCheckpointTriggered += CheckpointTriggered;

            checkpoint.SetActive(i == activeID ? true : false);
        }
    }

    #endregion

    #region Private Methods

    private void CheckpointTriggered (GameObject player)
    {
        checkpoints[activeID].SetActive(false);

        if (++activeID >= checkpoints.Length)
        {
            OnCourseComplete.Invoke();
        } else
        {
            checkpoints[activeID].SetActive(true);
        }
    }

    #endregion
}
