using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAnimationManager : MonoBehaviourPun
{
    #region Private Fields

    private Animator _animator;
    [SerializeField] private float directionDampTime = 0.25f;

    #endregion
    #region Monobehabiour Callbacks

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
        if (!_animator)
        {
            Debug.LogError("PlayerAnimatorManager is missing Animator component", this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Ensure the local machine owns the character and is connected online
        if (!photonView.IsMine && PhotonNetwork.IsConnected)
        {
            return;
        }
        if (!_animator)
        {
            return;
        }
        
        // Deal with Jumping
        AnimatorStateInfo stateInfo = _animator.GetCurrentAnimatorStateInfo(0);
        
        //Only allow jumping if we are running.
        if (stateInfo.IsName("Base Layer.Run"))
        {
            // When using trigger parameter
            if (Input.GetButton("Fire2"))
            {
                _animator.SetTrigger("Jump");
            }
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        if (v < 0)
        {
            v = 0;
        }
        _animator.SetFloat("Speed", h * h + v * v);
        
        _animator.SetFloat("Direction", h, directionDampTime, Time.deltaTime);
    }

    #endregion
}
