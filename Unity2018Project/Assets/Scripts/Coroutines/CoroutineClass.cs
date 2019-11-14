using System.Collections;
using UnityEngine;

public class CoroutineClass : MonoBehaviour
{
    public bool canRun = true;
    public int index = 3;
    private WaitForSeconds wfsObj;
    public float seconds = 1.5f;

    public void Run()
    {
        StartCoroutine(routine: OnRun());
        wfsObj = new WaitForSeconds(seconds);
    }
    IEnumerator OnRun()
    {
        while (index > 0)
        {
            Debug.Log(index);
            index--;
            yield return wfsObj;
        }
       
    }
    
}
