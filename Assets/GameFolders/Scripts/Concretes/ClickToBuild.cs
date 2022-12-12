using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToBuild : MonoBehaviour
{

    RaycastHit _rayInfo;
    public TowerController _tower;

    private void Awake()
    {

        _rayInfo = new RaycastHit();

    }

    private void Start()
    {

        _tower.gameObject.SetActive(false);

    }

    private void OnMouseDown()
    {

        if (Input.GetMouseButtonDown(0))
        {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            bool isRay = Physics.Raycast(ray.origin, ray.direction, out _rayInfo);

            if (isRay)
            {

                if (_rayInfo.collider != null && _rayInfo.collider.CompareTag("TowerGround"))
                {

                    StartCoroutine(BuildTower());

                }

            }

        }

    }

    private IEnumerator BuildTower()
    {

        yield return new WaitForSeconds(0f);
        _tower.gameObject.SetActive(true);

    }

}
