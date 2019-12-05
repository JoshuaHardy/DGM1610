using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireArrow : MonoBehaviour
{
    public GameObject arrow;

    //private bool hasFired = false;
   // public Vector3;

    void Update()
    {
        /*if ((Input.GetButton("Fire1") && hasFired = false))
        {
            Instantiate(arrow, transform.position, Quaternion.identity);
        }*/
        if (Input.GetButton("Fire1") )
        {
            Instantiate(arrow, transform.position, Quaternion.identity);

        }
    }
    
    
}
