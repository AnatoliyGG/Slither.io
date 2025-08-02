using System;
using UnityEngine;
using Unity.Netcode;

public class PlayerController : NetworkBehaviour 
{
    [SerializeField] private float speed = 3f;
    private Camera _mainCamera;
    private Vector3 _mouseInput;
    private void Initialize()
    {
        _mainCamera = Camera.main;
    }
    private void Update()
    {
        // Movement
        _mouseInput.x = Input.mousePosition.x;
        _mouseInput.y = Input.mousePosition.y;
        _mouseInput.z = _mainCamera.nearClipPlane;
        Vector3 mouseWorldCoordinates = _mainCamera.ScreenToWorldPoint((Vector3)_mouseInput);
        transform.position = Vector3.MoveTowards(current:transform.position, target:mouseWorldCoordinates,maxDistanceDelta:Time.deltaTime * speed);
        
        // Rotate
        if (mouseWorldCoordinates != transform.position)
        {
            
        }
    }
}