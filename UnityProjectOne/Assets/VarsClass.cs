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
        public UnityEvent arrowKeyUpEvent;
        public UnityEvent arrowKeyDownEvent;
        public UnityEvent arrowKeyLeftEvent;
        public UnityEvent arrowKeyRightEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        testEvent.Invoke();
        print("Watch where you're going!");
    }

    private void OnMouseDown()
    {
        mouseDownEvent.Invoke();
    }
    
   

    // voidUpdate method found onhttps://docs.unity3d.com/ScriptReference/KeyCode.html while looking for a way
    // to implement events that allow keyboard input


    
        // Update is called once per frame
        //Below Code is WIP for arrow key event functionality to add player movement
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("Space key was pressed.");
            }

            if (Input.GetKeyUp(KeyCode.Space))
            {
                print("Space key was released.");
            }
        }
}