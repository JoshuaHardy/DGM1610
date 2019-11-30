/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroAnimationScript : MonoBehaviour
{
    private Animator anim;
    public bool facingRight = true;
    public Vector3 theScale;
    
    // Start is called before the first frame update
    void Start()
    { 
        anim = GetComponent<Animator>();
        theScale = transform.localScale;
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal")>0) && facingRight = true)
        {
            Flip();
        }
        if (Input.GetAxis("Horizontal")<0) && facingRight = false);
        {
          Flip();  
        }
    }

    public void Fli1()
    {
        facingRight = !facingRight;
        transform.localRotation.y = -180;
    }
}
*/
