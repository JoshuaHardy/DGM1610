using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTargetIndex : MonoBehaviour
{
    // array used based upon tutorial code accessed 12/9/19 at "https://learn.unity.com/tutorial/arrays-9o#5c8a6c5fedbc2a067d475257"
    // Start is called before the first frame update
    public GameObject[] targetArray;
    void Start ()
    {
        targetArray = GameObject.FindGameObjectsWithTag("Targets");
        
        for(int i = 0; i < targetArray.Length; i++)
        {
            print("Player Number "+i+" is named "+targetArray[i].name);
        }
    }
}

