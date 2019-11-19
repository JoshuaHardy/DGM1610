using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class TimerCoroutine : MonoBehaviour
{
    public bool canRun = true;
    public int secondsTimer = 0, minutesTimer = 0;
    private WaitForSeconds timerWFS;
    public Text timerText;




    void Start ()
    {
        StartCoroutine(routine: OnRun());
        Time.timeScale = 1;
        timerWFS = new WaitForSeconds(1);
    }

    void Update()
    {
        string strMinutes = minutesTimer.ToString();
        string strSeconds = secondsTimer.ToString();
        if (minutesTimer < 10)
        {
            strMinutes = "0"+strMinutes;
        }
        
        if (secondsTimer < 10)
        {
            strSeconds = "0"+strSeconds;
        }
        timerText.text = strMinutes+":"+strSeconds;
    }
    

    IEnumerator OnRun()
    {
        while (secondsTimer < 60) /*& (timeLeft = 0)*/;
        {
            secondsTimer++;
            if (secondsTimer >= 60)
            {
                secondsTimer = 0;
                minutesTimer++;
                yield return timerWFS;
            }
            else
            { 
                yield return timerWFS; 
            }
        }
    }
}

//https://www.noob-programmer.com/unity3d/countdown-timer/
//https://answers.unity.com/questions/1273054/change-text-value.html

