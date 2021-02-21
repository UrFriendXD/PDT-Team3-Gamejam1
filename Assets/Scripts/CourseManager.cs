using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseManager : MonoBehaviour
{
    #region Private Serializable Fields

    [SerializeField] private CheckpointController[] checkpoints;

    #endregion

    #region Private Fields

    private int activeID = 0;

    #endregion

    #region Public Fields

    public Action<GameObject> OnCourseComplete;

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
            if (OnCourseComplete != null)
            {
                OnCourseComplete(player);
            }
        } else
        {
            checkpoints[activeID].SetActive(true);
        }
    }

    #endregion
}
