using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class VarsClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

        public float floatValue = 5.5f;
        public int intvalue = 20;
        public string stringValue = "Bob";
        public int firepower;
        public UnityEvent testEvent;
        public UnityEvent mouseDownEvent;
        private void OnTriggerEnter(Collider other)
    {
        testEvent.Invoke();
        print("Watch where you're going!");
    }
    private void OnMouseDown() 
        { 
            mouseDownEvent.Invoke(); 
        } 
    // Update is called once per frame
    void Update()
    {
        
    }
}
