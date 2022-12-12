using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColor : MonoBehaviour
{

    private Color startColor;
    public Color onMouseColor;

    Renderer _renderer;

    private void Start()
    {

        _renderer = GetComponent<Renderer>();
        startColor = _renderer.material.color;

    }

    private void OnMouseEnter()
    {

        _renderer.material.color = onMouseColor;

    }

    private void OnMouseExit()
    {

        _renderer.material.color = startColor;

    }

}
