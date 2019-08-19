using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    float timeCounter = 0;

    float speed;
    float width;
    float height;

    public Transform cameraTarget;

    // Start is called before the first frame update
    void Start()
    {
        speed = .2f;
     //   width = 0;
     //   height = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * 50;
        float y = 13;
        float z = Mathf.Sin(timeCounter) * 50;

        transform.position = new Vector3(x, y, z);

        transform.LookAt(cameraTarget);


    }
}
