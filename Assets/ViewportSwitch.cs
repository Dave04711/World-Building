using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewportSwitch : MonoBehaviour
{
    [Range(-22.2f, -7.8f)]
    [SerializeField] float offsetX;
    [SerializeField] GameObject viewObject;
    Vector3 startPos;

    private void Start()
    {
        startPos = viewObject.transform.position;
    }

    private void Update()
    {
        SetView();
    }

    void SetView()
    {
        viewObject.transform.position = startPos + Vector3.right * offsetX;
    }
}