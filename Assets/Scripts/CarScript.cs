using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CarScript : MonoBehaviour
{
    public Transform CarDestination;
    private NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = CarDestination.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Destination"))
        {
            Destroy(gameObject);
        }
        
        else if (other.CompareTag("Rear Bumper"))
        {
            agent.destination = transform.position;
        }
        
        else if (other.CompareTag("Traffic Light"))
        {
            agent.destination = transform.position;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Rear Bumper") || other.CompareTag("Traffic Light"))
        {
            agent.destination = CarDestination.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
