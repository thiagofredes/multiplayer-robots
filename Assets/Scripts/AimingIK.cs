using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimingIK : MonoBehaviour
{

    public Transform playerHeading;

    public float lookAtDistance;

    public string[] layerToIgnoreOnRaycast;

    private Animator _animator;


    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void OnAnimatorIK(int layer)
    {
        RaycastHit aimHit;
        Vector3 viewportPoint = new Vector3(0.5f, 0.5f, 0.5f);
        Ray screenRay = Camera.main.ViewportPointToRay(viewportPoint);

        if (Physics.Raycast(screenRay.origin, ThirdPersonCameraController.CameraForward, out aimHit, Camera.main.farClipPlane, ~LayerMask.GetMask(layerToIgnoreOnRaycast)))
        {
            _animator.SetLookAtWeight(1f, 0.8f, 1f, 1f, 0.5f);
            _animator.SetLookAtPosition(aimHit.point);
        }
        else
        {
            _animator.SetLookAtWeight(1f, 0.8f, 1f, 1f, 0.5f);
            _animator.SetLookAtPosition(playerHeading.position + ThirdPersonCameraController.CameraForward * lookAtDistance);
        }
    }
}
