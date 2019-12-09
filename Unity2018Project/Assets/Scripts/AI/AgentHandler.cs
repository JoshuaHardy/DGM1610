
using System;
 using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class AgentHandler : MonoBehaviour
{
    private NavMeshAgent agent;
    private Transform currentDestination;
    private GameObject startObj;
    public Transform destinationObj;

    void Start()
    {
        startObj = new GameObject();
        startObj.transform.position = transform.position;
        currentDestination = transform;
        agent = GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other)
    {
        currentDestination = destinationObj;
    }

    private void OnTriggerExit(Collider other)
    {
        currentDestination = startObj.transform;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = destinationObj.position;

        void Start()
        {
            startObj = new GameObject();
            startObj.transform.position = transform.position;
            currentDestination = transform;
            agent = GetComponent<NavMeshAgent>();
        }

        void OnTriggerEnter(Collider other)
        {
            currentDestination = destinationObj;
        }

        void OnTriggerExit(Collider other)
        {
            currentDestination = startObj.transform;
        }

        void Update()
        {
            agent.destination = currentDestination.position;

        }
    }
}
