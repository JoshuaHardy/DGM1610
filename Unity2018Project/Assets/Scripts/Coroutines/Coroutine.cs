using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Coroutines : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float seconds = 10f;
    public int counter = 10;
    public bool canRun;
    
    private WaitForSeconds wfsObj;
    private void Awake()
    {
        wfsObj = new WaitForSeconds(seconds);
    }

    public void CallCoroutine()
    {
        StartCoroutine(RunCoroutine());
    }
    
    IEnumerator RunCoroutine()
    {
        startEvent.Invoke();
        
        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return wfsObj;
            counter--;
        }
        
        while (canRun)
        {
            repeatEvent.Invoke();
            yield return wfsObj;
            counter--;
        }
        
        endEvent.Invoke();
    }
}