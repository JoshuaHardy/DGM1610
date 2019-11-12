/*
using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinemachineController : MonoBehaviour
{
    public PlayerData playerData;
    private CinemachineVirtualCamera virtualCamera;
    void Awake()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        
    }

    private void InstanceHandler(GameObject obj)
    {
        virtualCamera.Follow = obj.transform;
        playerData.instanceAction = InstanceHandler;
        playerData.InstancePlayer();
    }
    
}
*/
