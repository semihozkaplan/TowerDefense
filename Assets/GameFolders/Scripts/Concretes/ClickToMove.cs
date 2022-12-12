using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClickToMove : MonoBehaviour
{

    RaycastHit _rayInfo;
    NavMeshAgent _agent;
    

    private void Awake()
    {

        _agent = GetComponent<NavMeshAgent>();
        _rayInfo = new RaycastHit();

    }

    private void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out _rayInfo))
            {
                
                _agent.destination = _rayInfo.point;

            }

        }

    }



}
