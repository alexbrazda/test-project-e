﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    public Camera MainCamera;
    public Transform CameraPosition;

    public float MouseSensitivity = 10.00f;

    float m_VerticalAngle, m_HorizontalAngle;
    
    // Start is called before the first frame update
    void Start()
    {
        MainCamera.transform.SetParent(CameraPosition, false);
        MainCamera.transform.localPosition = Vector3.zero;
        MainCamera.transform.localRotation = Quaternion.identity;
    }

    // Update is called once per frame
    void Update()
    {
            // Turn player
            float turnPlayer =  Input.GetAxis("Mouse X") * MouseSensitivity;
            m_HorizontalAngle = (m_HorizontalAngle + turnPlayer) % 360;

            if (m_HorizontalAngle < 0)
                m_HorizontalAngle += 360;

//            if (m_HorizontalAngle > 360) m_HorizontalAngle -= 360.0f;
//            if (m_HorizontalAngle < 0) m_HorizontalAngle += 360.0f;
            
            Vector3 currentAngles = transform.localEulerAngles;
            currentAngles.y = m_HorizontalAngle;
            transform.localEulerAngles = currentAngles;

            // Camera look up/down
            var turnCam= -Input.GetAxis("Mouse Y");
            turnCam = turnCam * MouseSensitivity * 0.3f; //30% sensitivity of X sensitivity
            m_VerticalAngle = Mathf.Clamp(turnCam + m_VerticalAngle, -89.0f, 89.0f);

            currentAngles = CameraPosition.transform.localEulerAngles;
            currentAngles.x = m_VerticalAngle;
            CameraPosition.transform.localEulerAngles = currentAngles;
    }
}
