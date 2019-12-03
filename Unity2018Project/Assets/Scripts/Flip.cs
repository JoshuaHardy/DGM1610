using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flip : MonoBehaviour

{
    public Vector3Data data;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           transform.rotation = Quaternion.Euler(0,180,0);
           data.value.x = 1;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler (0,0,0);
            data.value.x = -1;
        }
        
    }
}

// If input horizontal > 0 && 
