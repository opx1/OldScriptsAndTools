using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AIBehavior : MonoBehaviour
{

    private NavMeshAgent agent;
    private Transform destination;

    public List<Transform> patrolPoints;
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        destination = transform;
    }

    private void OnTriggerEnter(Collider other)
    {
        destination = other.transform;
    }

    private void OnTriggerExit(Collider other)
    {
        destination = Patrol();
    }

    private Transform Patrol()
    {
        return transform;
    }

    private void Update()
    {
        agent.destination = destination.position;
    }
}
