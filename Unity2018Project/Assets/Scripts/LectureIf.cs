using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LectureIf : MonoBehaviour
{
    public int a = 4;

    public int b = 5;

    public int c = 10;

    public string password = "OU812";

    public bool lightsOn = true;
    
    // Start is called before the first frame update
    void Start()
    {
        if (a+b == c)
        {
            print(true);
        }

        if (password == "OU812") 
        {
            print(true);
        }

        if (lightsOn)
        {
            print(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
