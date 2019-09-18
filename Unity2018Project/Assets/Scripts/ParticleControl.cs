using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ParticleControl : MonoBehaviour
{

    public ParticleSystem particles;
    // Start is called before the first frame update
    void Start()
    {
        particles.Emit(count: 100);
    }

    private void OnMouseDown()
    {
        particles.Pause();
    }

    private void OnMouseUp()
    {
        particles.Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
