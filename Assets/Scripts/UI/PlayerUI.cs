using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    #region Private Fields

    [Tooltip("UI text to display Player's Name")] [SerializeField]
    private TextMeshProUGUI playerNameText;
    
    [Tooltip("UI Slider to display Player's Health")] [SerializeField]
    private Slider playerHealthSlider;

    private PlayerManager target;

    private float characterControllerHeight = 0f;
    private Transform targetTransform;
    private Renderer targetRenderer;
    private CanvasGroup _canvasGroup;
    private Vector3 targetPosition;
    
    #endregion

    #region Public Fields

    [Tooltip("Pixel offset from the player targer")] [SerializeField]
    private Vector3 screenOffset = new Vector3(0f, 30f, 0f);

    #endregion

    #region MonoBehaviour Callbacks

    private void Awake()
    {
        transform.SetParent(GameObject.Find("Canvas").GetComponent<Transform>(), false);
        _canvasGroup = GetComponent<CanvasGroup>();
    }

    private void Update()
    {
        // Remove later
        // // Reflect the Player Health
        // if (playerHealthSlider != null)
        // {
        //     playerHealthSlider.value = target.health;
        // }

        if (target == null)
        {
            Destroy(gameObject);
            return;
        }
    }

    private void LateUpdate()
    {
        // Do not show the UI if we are not visible to the camera, thus avoid potential bugs with seeing the UI, but not the player itself.
        if (targetRenderer != null)
        {
            _canvasGroup.alpha = targetRenderer.isVisible ? 1f : 0f;
        }
        
        // #Critical
        // Follow the Target GameObject on screen.
        if (targetTransform != null)
        {
            targetPosition = targetTransform.position;
            targetPosition.y += characterControllerHeight;
            transform.position = Camera.main.WorldToScreenPoint(targetPosition) + screenOffset;
        }
    }

    #endregion


    #region Public Methods

    public void SetTarget(PlayerManager _target)
    {
        if (_target == null)
        {
            Debug.LogError("<Color=Red><a>Missing</a></Color> PlayMakerManager target for PlayerUI.SetTarget.", this);
        }
        
        // Cache references for efficiency
        target = _target;

        targetTransform = target.GetComponent<Transform>();
        targetRenderer = target.GetComponent<Renderer>();
        CharacterController characterController = target.GetComponent<CharacterController>();
        if (characterController != null)
        {
            characterControllerHeight = characterController.height;
        }
        
        if (playerNameText != null)
        {
            Debug.Log(target.photonView.Owner.NickName);
            playerNameText.text = target.photonView.Owner.NickName;
        }
    }

    #endregion
}