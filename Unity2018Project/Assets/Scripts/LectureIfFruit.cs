using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class LectureIfFruit : MonoBehaviour
{
    public bool appleIsRipe, orangeIsRipe, peachIsRipe;
    // Start is called before the first frame update
    void Start()
    {
        if (appleIsRipe)
        {
            print("Go Pick The Apple");
        }
        else if (orangeIsRipe)
        {
            print("Go Pick The Orange");
        }
        else if (peachIsRipe)
        {
            print("Go Pick The Peach");
        }
        else
        {
            print("Nothing is Ripe.");
        }
    }

    // Update is called once per frame
    // ** You want to avoid coding too many if statements into Update, as it can really bog down your game. **
    void Update()
    {
        
    }
}
