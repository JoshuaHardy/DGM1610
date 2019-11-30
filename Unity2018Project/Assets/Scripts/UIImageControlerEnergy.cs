using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class UIImageControllerEnergy : MonoBehaviour
{
    private Image img;
    void Awake()
    {
        img = GetComponent<Image>();
    }

    private void Start()
    {
//        GameObject Player = GameObject.Find(Player);
    }

    public void UpdateImage(FloatData data)
    {
        img.fillAmount = data.value;
    }
    
}