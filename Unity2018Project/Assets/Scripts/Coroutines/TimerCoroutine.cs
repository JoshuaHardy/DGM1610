using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerCoroutine : MonoBehaviour
{
    public bool canRun = true;
    public int secondsTimer = 0; //minutesTimer = 0;
    private WaitForSeconds timerWFS;
    public Text timerText;
    


    public void Run()
    {
        StartCoroutine(routine: OnRun());
        timerWFS = new WaitForSeconds(1);
        

    }
    IEnumerator OnRun()
    {
        while (secondsTimer < 60)
        {
            secondsTimer++;
            yield return timerWFS;
            if (secondsTimer >= 60)
            {
                secondsTimer = 0;
                //minutesTimer++;
            }
        }
       
    }

    void Update()
    {
        timerText.text = secondsTimer.ToString();
        //timerText.text = minutesTimer.ToString();
        //timerText.text = (minutesTimer":"secondsTimer);
    }
}
//https://www.noob-programmer.com/unity3d/countdown-timer/
//https://answers.unity.com/questions/1273054/change-text-value.html