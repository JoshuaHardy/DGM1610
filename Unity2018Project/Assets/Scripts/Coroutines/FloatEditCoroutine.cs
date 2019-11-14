/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class FloatEditCoroutine : MonoBehaviour

public float regenRate = .25f, regenAmount = .08f;
public FloatData
private WaitForSeconds regen;

{
    private void Awake()
    {
        regen = new WaitForSeconds(regenRate);
    }
    IEnumerator Start()
    {
        if (true)
        {
            yield return regen;
            Debug.Log(message:"Run");
        }

    }
}*/