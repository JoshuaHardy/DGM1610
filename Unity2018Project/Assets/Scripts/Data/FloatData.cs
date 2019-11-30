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
        value = amount;
        // alternative syntaax is: {value = value + amount;} but the given syntax does the same and is shorter

        /*if (value <= maxValue)
        {
            value = amount;
        }
        else
        {
            value = maxValue;
        }

        if (value >= minValue)
        {
            value = amount;
        }
        else
        {
            value = minValue;
        }*/
    }
}
