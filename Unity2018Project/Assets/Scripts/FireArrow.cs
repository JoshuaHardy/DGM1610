using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

public class FireArrow : MonoBehaviour
{
    public GameObject arrow;
    public float fireRate = 2f;
    public WaitForSeconds fireDelay;
    public Vector3Data data;
    public IntData facingDirection;
    //public Vector3Data facingDirection = (0,0,0);
    
    //private bool hasFired = false;
   // public Vector3;

   private void Awake()
   {
       //throw new NotImplementedException();
   }

   void Update()
    {
        /*if ((Input.GetButton("Fire1") && hasFired = false))
        {
            Instantiate(arrow, transform.position, Quaternion.identity);
        }*/
        

        if (Input.GetButton("Fire1") )
        {
            Instantiate(arrow, transform.position, Quaternion.Euler(0, 0 , 0));

        }
        /*if (Input.GetButton("Fire1") 
        {
            Instantiate(arrow, transform.position, Quaternion.Euler(0, 180 , 0));

        }*/
        
        /*if (Input.GetButton("Fire1") )
        {
            Instantiate(arrow, transform.rotation = Quaternion.Euler(0, 180 , 0);

        }*/
        
    }
    
    
}
