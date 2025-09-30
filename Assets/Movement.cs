using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    public Camera playerCamera;
    public float walkSpeed = 6f; 

    private Vector3 moveDirection = Vector3.zero;
    private CharacterController characterController;

    private bool canMove = true;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
    }

    void Update()
    {
        Vector3 right = transform.TransformDirection(Vector3.right);
        float curSpeedX = canMove ? walkSpeed * Input.GetAxis("Horizontal") : 0;
        

        moveDirection = right * curSpeedX;

        characterController.Move(moveDirection * Time.deltaTime);
    }
}