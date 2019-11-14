using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerCoroutine : MonoBehaviour
{
    public bool canRun = true;
    public int minutesTimer = 0, secondsTimer = 0;
    private WaitForSeconds timerWFS;
    public Time = 00.00f;


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
            if (secondsTimer == 60)
            {
                secondsTimer = 0;
                minutesTimer++;
            }
        }
       
    }
}
