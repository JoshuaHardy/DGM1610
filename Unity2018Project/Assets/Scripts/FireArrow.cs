using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.TextCore;

public class FireArrow : MonoBehaviour
{
    public GameObject arrow;
    public float fireRate = 1f;
    public WaitForSeconds fireDelay;
    public Vector3Data data;
    public IntData facingDirection;
    public bool facingRight = true;
    private int arrowsFired = 0;
    private int switchCaseIndex = 0;
    public Animator bowAnimator;
    public bool fireArrow = false;
    public WaitForSeconds waitForSeconds;

    enum direction {Left, Right};
    direction playerDirection;
    

    private void Awake()
   {
       waitForSeconds = new WaitForSeconds(fireRate);
       playerDirection = direction.Right;
   }

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || (Input.GetKey(KeyCode.A)))
        {
            facingRight = false;
            playerDirection = direction.Left;
        }

        if (Input.GetKey(KeyCode.RightArrow) || (Input.GetKey(KeyCode.D)))
        {
            facingRight = true;
            playerDirection = direction.Right;
        }

        if (Input.GetButtonDown("Fire1") && facingRight == true )
        {
            Instantiate(arrow, transform.position, Quaternion.Euler(0, 0 , 0));
            arrowsFired++;
            arrowCounterSwitch();
            
        }
        if (Input.GetButtonDown("Fire1") && facingRight == false )
        {
            Instantiate(arrow, transform.position, Quaternion.Euler(0, 180 , 0));
            arrowsFired++;
            arrowCounterSwitch();
        }
    }
   
   void arrowCounterSwitch()
   {
       if (arrowsFired <= 0)
       {
           switchCaseIndex = 0;
       }
       if (arrowsFired == 1)
       {
           switchCaseIndex = 1;
       }
       if (arrowsFired >= 2)
       {
           switchCaseIndex = 2;
       }
       switch (switchCaseIndex)
       {
           case 1:
           {
               print(arrowsFired + " Arrow Fired.");
               break;
           }
           case 2:
           {
               print(arrowsFired + " Arrows Fired.");
               break;
           }
           default:
           {
               print("Arrow Count Error");
               break;
           }
       }
   }
   
   /*IEnumerator()
   {
       fireArrow = true;
       if (facingRight)
       {
           Instantiate(arrow, transform.position, Quaternion.Euler(0, 0, 0));
           arrowsFired++;
           arrowCounterSwitch();
       }
       if (!(facingRight))
       {
           Instantiate(arrow, transform.position, Quaternion.Euler(0, 180, 0));
           arrowsFired++;
           arrowCounterSwitch();
       }
       fireArrow = false;
   }*/


}
