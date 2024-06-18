using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform target; // Assign your sprite's transform here
    public float smoothSpeed = 0.125f; // Smoothing factor for camera movement

    void LateUpdate()
    {
        Vector3 offset = target.position - transform.position;
        transform.position = Vector3.SmoothDamp(transform.position, target.position, ref offset, smoothSpeed);
    }
}
