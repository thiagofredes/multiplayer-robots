﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : GameObjectState
{

    private CharacterController _characterController;

    private Animator _animator;

    private float _playerMovementSpeed;

    public Shooting(Player player)
    {
        _controlledBehaviour = player;
        _characterController = ((Player)player).characterController;
        _animator = ((Player)player).playerAnimator;
        _playerMovementSpeed = ((Player)player).movementSpeed;
    }

    public override void Update()
    {
        float forwardMovement = Input.GetAxis("Vertical");
        float sideMovement = Input.GetAxis("Horizontal");

        if (Input.GetMouseButtonUp(0))
        {
            _controlledBehaviour.SetState(new Running((Player)_controlledBehaviour));
            return;
        }

        _controlledBehaviour.transform.forward = ThirdPersonCameraController.CameraForwardProjectionOnGround;
        _characterController.Move(
            (
                ThirdPersonCameraController.CameraForwardProjectionOnGround * forwardMovement +
                ThirdPersonCameraController.CameraRightProjectionOnGround * sideMovement
            ) *
            Time.deltaTime * _playerMovementSpeed
        );
        _animator.SetFloat("Forward", forwardMovement);
        _animator.SetFloat("Side", Vector3.Dot(
            ThirdPersonCameraController.CameraRightProjectionOnGround,
            sideMovement * _controlledBehaviour.transform.right
        ));
    }
}
