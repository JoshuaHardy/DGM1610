using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]

public class GroundedData : ScriptableObject

{
    private CharacterController controller;
    public UnityEvent airborne, grounded;
    void Start()
    {
        
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            grounded.Invoke();
        }
        
        else
        {
            airborne.Invoke();
        }
    }
}

