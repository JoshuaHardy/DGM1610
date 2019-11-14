using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value = 1f;
    public float minValue = 0f;
    public float maxValue = 1f;
    
    public void UpdateValue(float amount)
    {
        value += amount; 
        // alternative syntaax is: {value = value + amount;} but the given syntax does the same and is shorter
    }

    public void UpdateValueRange(float amount)
    {
        /*if (value <= maxValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = maxValue;
        }
        
        if (value >= minValue)
        {
            UpdateValue(amount);
        }
        else
        {
            value = minValue;
        }*/
        if (value > maxValue)
        {
            value = maxValue;
        }

        if (value < minValue)
        {
            value = minValue;
        }
    }
}
