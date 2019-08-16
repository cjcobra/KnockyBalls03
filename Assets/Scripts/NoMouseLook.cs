using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoMouseLook : MonoBehaviour
{
    public float speedH = 0.0f;
    public float speedV = 0.0f;

    public float yaw = 0.0f;
    public float pitch = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.lockState = CursorLockMode.Confined;

        //     yaw += speedH * Input.GetAxis("Mouse X");
        //     pitch -= speedV * Input.GetAxis("Mouse Y");

        //    yaw = Mathf.Clamp(yaw, -0f, 0f);  // -90,90
        //the rotation range
        //    pitch = Mathf.Clamp(pitch, -0f, 0f);  // -60,90
        //the rotation range

        //    transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

    }
}
