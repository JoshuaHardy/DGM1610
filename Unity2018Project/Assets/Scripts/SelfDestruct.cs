using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public float delay = 3f;
    void Start()
    {
        Destroy(gameObject, delay);
    }

    /*public void destroyOnImpact;
    {
        Destroy(gameObject);
    }*/
}
