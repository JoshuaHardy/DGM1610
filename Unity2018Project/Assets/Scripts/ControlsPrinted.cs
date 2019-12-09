using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsPrinted : MonoBehaviour
{
    void Start () 
    {
        string[] introText = new string[5];
        
        introText[0] = "Use WASD To Move";
        introText[1] = "Press the Spacebar to Jump";
        introText[2] = "Hold Shift to Move Faster and Jump Higher";
        introText[3] = "Press Control or Click the Primary Mouse Button to Fire Arrows";
        introText[4] = "Clear all 10 Targets To Win!";
        
        foreach(string item in introText)
        {
            print (item);
        }
    }
}
