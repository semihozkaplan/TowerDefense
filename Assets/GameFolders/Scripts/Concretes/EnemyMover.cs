using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMover : IEnemyMover
{

    Vector3 _endTarget;
    NavMeshAgent _navAgent;
    float _moveSpeed;

    public EnemyMover(Vector3 endTarget, NavMeshAgent navAgent, float moveSpeed)
    {

        _endTarget = endTarget;
        _navAgent = navAgent;
        _moveSpeed = moveSpeed;

    }

    public void MoveToTarget()
    {

        _navAgent.speed = _moveSpeed;
        _navAgent.SetDestination(_endTarget);

    }


}
