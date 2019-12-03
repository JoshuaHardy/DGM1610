using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]

public class LectureApplyForce : MonoBehaviour
{
    private Rigidbody rb;

    public Vector3Data forceDirection;
    public float force = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(forceDirection.value*force);
    }

    // Update is called once per frame
/*    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(forceDirection.value*force);
    }*/
}

