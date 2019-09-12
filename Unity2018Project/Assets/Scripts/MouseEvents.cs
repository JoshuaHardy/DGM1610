using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{
    public UnityEvent mouseDown;
    public UnityEvent mouseUp;
    private void OnMouseDown()
    {
        mouseDown.Invoke();
    }

    private void OnMouseUp()
    {
        mouseUp.Invoke();
    }
    
}