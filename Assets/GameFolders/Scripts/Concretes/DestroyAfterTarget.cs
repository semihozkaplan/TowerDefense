using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTarget : MonoBehaviour
{

    [SerializeField] GameObject _endTarget;

    private void Update()
    {

        if (Mathf.Abs(Vector3.Distance(this.gameObject.transform.position, _endTarget.transform.position)) < 0.6f)
        {

            WaitForDestroy();

        }

    }

    private void WaitForDestroy()
    {

        StartCoroutine(DestroyThisObject());

    }

    private IEnumerator DestroyThisObject()
    {

        yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);

    }

}
