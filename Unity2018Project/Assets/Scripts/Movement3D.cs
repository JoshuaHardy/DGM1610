﻿/*using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1f;
    public float gravity = -3f;
    public float jumpSpeed = 10f;
    private Vector3 position;
    public CharacterController controller;
    private int jumpCount = 2;
    
    
    void Update()
    {
        position.x = speed*Input.GetAxis("Horizontal");
        position.y -= gravity;
        position.z = speed*Input.GetAxis("Vertical");
        if (!controller.isGrounded)
        {
            position.y = 0; jumpCount = 0;
        }
       
        if (controller.isGrounded)
        {
            jumpCount=2;
        }
       
        if (Input.GetButtonDown("Jump"))
            //"Jump" Is Mapped to the space bar by default in unity
        {
            position.y = jumpSpeed;
            jumpCount--;
        }
        controller.Move(position*Time.deltaTime);
       
    }
}*/