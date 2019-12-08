using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Flip : MonoBehaviour

{
    public Vector3Data data;
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
           transform.rotation = Quaternion.Euler(0,180,0);
           data.value.x = -1;
        }

        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            transform.rotation = Quaternion.Euler (0,0,0);
            data.value.x = +1;
        }
        
    }
}