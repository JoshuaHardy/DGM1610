/*using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.AI;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDown;
    public UnityEvent mouseUp;
    public Vector3 data;
    public Camera cam;
    
    private void Start()
    {
        cam = Camera.main;
    }
    private void OnMouseDown()
    {
        mouseDown.Invoke();
        RaycastHit hit;
        var ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out var hit))
        {
            data.value = hit.point
        }        
        Debug.Log(hit);
    }

    private void OnMouseUp()
    {
        mouseUp.Invoke();
    }
    
    Onmouserigh

    
}*/