using System;
using UnityEngine;
using Unity.Netcode;

public class PlayerController : NetworkBehaviour
{
    private Camera _mainCamera;
    private Vector3 _mouseInput;
    private void Initialize()
    {
        _mainCamera = Camera.main;
    }
    private void Update()
    {
        _mouseInput.x = Input.mousePosition.x;
        _mouseInput.y = Input.mousePosition.y;
        _mouseInput.y = _mainCamera.nearClipPlane;
        Vector3 mouseWorldCoordinates = _mainCamera.ScreenToWorldPoint((Vector3)mousePositionScreen);
    }
}
