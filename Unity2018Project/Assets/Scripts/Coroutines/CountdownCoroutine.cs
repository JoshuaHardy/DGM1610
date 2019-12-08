using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

//Countdown tutorial found online https://www.noob-programmer.com/unity3d/countdown-timer/

[CreateAssetMenu]
public class CountdownCoroutine : MonoBehaviour
{
    public int timeLeft = 60; //Seconds Overall
    public Text countdown; //UI Text Object
    void Start () 
    {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right
    }
    void Update ()
    {
        if (timeLeft >= 1)
        {
            countdown.text = ("" + timeLeft); //Showing the Score on the Canvas 
        }
        else
        {
            countdown.text = ("GO!");
        }

        if (timeLeft <= -1)
        {
            countdown.text = (" ");
        }
        
    }
    //Simple Coroutine
    IEnumerator LoseTime()
    {
        while (timeLeft > -1) 
        {
            yield return new WaitForSeconds (1);
            timeLeft--; 
        }

        while (timeLeft == 1)
        {
            yield return new WaitForSeconds (1);
            countdown.text = ("test");
        }
    }
}