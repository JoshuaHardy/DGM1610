using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForSpawner : MonoBehaviour


{
    public WaitForSeconds delay;
     public  int maxSpawn = 3;
     public GameObject spawnedObject;
     public float spawnPeriod = 5f;
     private void Awake()
     {
         delay = new WaitForSeconds(spawnPeriod);
     }
     void Start ()
     {
         StartCoroutine(SpawnGameObjectCoroutine ());
     }

     IEnumerator SpawnGameObjectCoroutine()
     {
         for(int i = 0; i < maxSpawn; i++)
         {
             Instantiate(spawnedObject, transform.position, Quaternion.Euler(0, 0 , 0));
             yield return delay;
         }
     }
   }