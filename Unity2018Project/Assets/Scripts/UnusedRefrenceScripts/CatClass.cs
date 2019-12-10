using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatClass : MonoBehaviour
{
    public UnityEvent catStuff;
    public UnityEvent catStuffTwo;
    private void OnMouseDown()
    {
        catStuff.Invoke();
    }

    private void OnMouseUp()
    {
        catStuffTwo.Invoke();
    }
    
}