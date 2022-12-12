using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyController : MonoBehaviour, IEntityController
{

    EnemyMover _enemyMover;
    [SerializeField] GameObject _endTarget;

    [SerializeField] float _moveSpeed = 1f;

    private void Awake()
    {

        _enemyMover = new EnemyMover(_endTarget.transform.position, GetComponent<NavMeshAgent>(), _moveSpeed);

    }

    private void Start()
    {

        _enemyMover.MoveToTarget();

    }


}
