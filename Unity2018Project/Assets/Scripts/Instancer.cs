using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Quaternion = UnityEngine.Quaternion;
using Vector2 = System.Numerics.Vector2;

public class Instancer : MonoBehaviour
{
    public GameObject prefab;
    public void CreateInstance()
    {
        Instantiate(prefab, transform.position, Quaternion.identity);
    }
}
