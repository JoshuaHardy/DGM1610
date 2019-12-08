using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Flip : MonoBehaviour

{
    public Vector3Data data;
    public UnityEvent faceLeft;
    public UnityEvent faceRight;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
           transform.rotation = Quaternion.Euler(0,180,0);
           data.value.x = -1;
           faceLeft.Invoke();
        }

        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.rotation = Quaternion.Euler (0,0,0);
            data.value.x = +1;
            faceRight.Invoke();
        }
        
    }
}

// If input horizontal > 0 && 
