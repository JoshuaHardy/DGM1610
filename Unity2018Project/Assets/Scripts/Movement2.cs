using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Movement2 : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 position;
    private int jumpCount;
    
    public float moveSpeed = 10f, gravity = 9.81f, jumpSpeed = 30f;
    public int jumpCountMax = 4;
    
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        position.x = moveSpeed*Input.GetAxis("Horizontal");
        controller.Move(position*Time.deltaTime);
        position.y -= gravity;
        if (controller.isGrounded)
        {
            position.y = 0; jumpCount=0;
        }
        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
    }
}
