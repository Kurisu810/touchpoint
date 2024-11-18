using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestThumbstickInput : MonoBehaviour
{
    void Update()
    {
        // 获取右手柄摇杆输入
        Vector2 thumbstickInput = OVRInput.Get(OVRInput.Axis2D.SecondaryThumbstick);

        // 打印摇杆输入
        Debug.Log("Thumbstick Input: " + thumbstickInput);
    }
}
