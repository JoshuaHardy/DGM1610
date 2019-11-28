using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]

public class Movement2 : MonoBehaviour
{
    
    private CharacterController controller;
    private Vector3 position;
    private int jumpCount;

    public float moveSpeed = 10f,
        gravity = 9.81f,
        jumpSpeed = 30f,
        sprintVar = 1.5f,
        jumpSprintVar = 1.5f,
        energyRegen = .2f,
        Energy = 1;

    public int jumpCountMax = 4;
    private bool energyRegenTrigger, isSprinting;

    public UnityEvent jumpEvent, sprintEvent;

    private WaitForSeconds energyRegenRate;

    /*private void Input.GetButtonDown("Fire3")
    {
        sprintEvent.Invoke;
    }

    private void Input.GetButtonDown("Jump")
    {
        jumpEvent.Invoke;
    }*/
        
    private void Awake()
    {
        energyRegenRate = new WaitForSeconds(.25f);
    }

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (isSprinting == false && controller.isGrounded)
        {
            bool energyRegenTrigger = true;
        }
        else
        {
            bool energyRegenTrigger = false;
        }

        if (energyRegenTrigger == true)
        {
            Energy += energyRegen;
        }
        if (Input.GetButtonDown("Fire3"))
        {
            moveSpeed *= sprintVar;
            jumpSpeed *= jumpSprintVar;
            isSprinting = true;
        }

        if (Input.GetButtonUp("Fire3"))
        {
            moveSpeed /= sprintVar;
            jumpSpeed /= jumpSprintVar;
            isSprinting = false;
        }

        position.x = moveSpeed * Input.GetAxis("Horizontal");
        controller.Move(position * Time.deltaTime);
        position.y -= gravity;
        if (controller.isGrounded)
        {
            position.y = 0;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            position.y = jumpSpeed;
            jumpCount++;
        }
    }
}

