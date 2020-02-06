using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    private Transform lookAt;
    private Transform camTransform;

    private Camera cam;

    private float distance = 10.0f;
    private float currentX = 0.0f;
    private float currentY = 0.0f;

    private const float Y_Angle_Min = 0.0f;
    private const float Y_Angle_Max = 50.0f;
    
    private void Start()
    {
        lookAt = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        camTransform = transform;
        cam = Camera.main;
        
    }

    private void Update()
    {
        currentX += Input.GetAxis("Mouse X");
        currentY += Input.GetAxis("Mouse Y");

        currentY = Mathf.Clamp(currentY, Y_Angle_Min, Y_Angle_Max);
    }

    private void LateUpdate()
    {
        Vector3 dir = new Vector3(0,0,-distance);
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        camTransform.position = lookAt.position + rotation * dir;
        camTransform.LookAt(lookAt.position);
        
    }
}
