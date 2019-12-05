using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameActionRaiser : MonoBehaviour
{
    public float holdTime = 1f;
    public WaitForSeconds waitForSeconds;
    private bool canRun = true;
    public GameAction gameActionObj;

    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(holdTime);
    }

    
    private IEnumerator OnMouseDown()
    {
        canRun = true;
        while (true)
        {
            gameActionObj.Raise();
            yield return waitForSeconds;
            print(message: "Down");
        }
    }

    private void OnMouseUp()
    {
        canRun = false;
    }
}
