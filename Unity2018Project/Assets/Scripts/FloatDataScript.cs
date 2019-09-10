using UnityEngine;

[CreateAssetMenu]
public class FloatDataScript : ScriptableObject
{
    public float value = 1f;

    public void UpdateValue(float amount)
    {
        value += amount; 
        // alternative syntaax is: {value = value + amount;} but the given syntax does the same and is shorter
    }
}
