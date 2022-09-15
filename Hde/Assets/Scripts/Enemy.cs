using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy : MonoBehaviour
{

    public Transform target;

    public NavMeshAgent agent;


    // Update is called once per frame
    void Update()
    {

        if (target)
        {
            agent.SetDestination(target.position);
        }
        
    }

 
}
