using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    ObjectAnimation _doorAnim;
    EnemyController _enemy;

    private void Awake()
    {

        _doorAnim = new ObjectAnimation(GetComponent<Animator>());
        _enemy = FindObjectOfType<EnemyController>();

    }


    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {

            _doorAnim.DoorOpenAnim();

        }

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Enemy"))
        {

            _doorAnim.DoorCloseAnim();

        }

    }

}
