using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.Events;

public class DogClass : MonoBehaviour
{
    public UnityEvent doesStuff;
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        doesStuff.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
