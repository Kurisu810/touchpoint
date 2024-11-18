using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class CameraMovementController : MonoBehaviour
{
    public Transform cameraTransform; // 摄像机对象
    public float moveSpeed = 2.0f;    // 移动速度
    public float rotationSpeed = 60.0f; // 旋转速度

    void Update()
    {
        // 获取右手柄摇杆的输入
        Vector2 thumbstickInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

        // 通过摇杆前后移动摄像机
        Vector3 forwardMovement = cameraTransform.forward * thumbstickInput.y * moveSpeed * Time.deltaTime;

        // 通过摇杆左右旋转摄像机
        Vector3 rotation = new Vector3(0, thumbstickInput.x * rotationSpeed * Time.deltaTime, 0);

        // 应用移动和旋转
        cameraTransform.position += forwardMovement; // 移动
        cameraTransform.Rotate(rotation);            // 旋转
    }
}
