﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{

    private NavMeshAgent mNavMeshAgent;

    private bool running = false;

    // Start is called before the first frame update
    void Start()
    {

        mNavMeshAgent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if(Physics.Raycast(ray, out hit, 100))
            {
                mNavMeshAgent.destination = hit.point;
            }
        }

        if(mNavMeshAgent.remainingDistance <= mNavMeshAgent.stoppingDistance)
        {
            running = false;
        }
        else
        {
            running = true;
        }
    }
}
