using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalPlayerAnimator : MonoBehaviour
{
    [SerializeField] LocalController _player;
    private Animator _playerAnimator;

    const string IS_WALKING = "IsWalking";

    private void Awake()
    {
        _playerAnimator = GetComponent<Animator>();
    }
    private void OnEnable()
    {
        _player.PlayerWalkingChanged += SetAnimationState;
    }
    private void OnDisable()
    {
        _player.PlayerWalkingChanged -= SetAnimationState;
    }

    /// <summary>
    /// Sets animator boolean based on player state
    /// </summary>
    /// <param name="isWalking">Whether player is currently walking</param>
    public void SetAnimationState(bool isWalking)
    {
        _playerAnimator.SetBool(IS_WALKING, isWalking);
    }
}
