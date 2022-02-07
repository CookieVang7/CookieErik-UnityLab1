using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform mainTransform;
    [SerializeField] private Transform target;

    private void FixedUpdate()
    {
        Vector3 currentPos = mainTransform.position;
        currentPos.x = target.position.x;
        currentPos.y = Math.Max(5, target.position.y);
        mainTransform.position = currentPos;
    }
}
