﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public float near = 20.0f;
    public float far = 100.0f;

    public float sensitivityX = 10f;
    public float sensitivityY = 10f;
    public float sensitivetyZ = 2f;
    public float sensitivetyMove = 2f;
    public float sensitivetyMouseWheel = 2f;


    void Update()
    {
        // 滚轮实现镜头缩进和拉远
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            this.GetComponent<Camera>().fieldOfView = this.GetComponent<Camera>().fieldOfView - Input.GetAxis("Mouse ScrollWheel") * sensitivetyMouseWheel;
            this.GetComponent<Camera>().fieldOfView = Mathf.Clamp(this.GetComponent<Camera>().fieldOfView, near, far);
        }
        //鼠标右键实现视角转动，类似第一人称视角
        if (Input.GetMouseButton(1))
        {
            float rotationX = Input.GetAxis("Mouse X") * sensitivityX;
            float rotationY = Input.GetAxis("Mouse Y") * sensitivityY;
            transform.Rotate(-rotationY, rotationX, 0);
        }

        //键盘按钮←和→实现视角水平旋转
        if (Input.GetAxis("Horizontal") != 0)
        {
            float rotationZ = Input.GetAxis("Horizontal") * sensitivetyZ;
            transform.Rotate(0, 0, rotationZ);
        }
    }

}