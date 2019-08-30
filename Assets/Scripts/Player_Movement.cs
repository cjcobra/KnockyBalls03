using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    float timeCounter = 0;

    float speed;
    float width;
    float height;
    float distance;
    int rotDir;

    public Transform cameraTarget;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player_Movement: Start");
        speed = Random.Range(1.1f, 1.5f);
        distance = Random.Range(35, 70);
        rotDir = Random.Range(0, 2);

        Debug.Log("Speed: " + speed);
        Debug.Log("Distance: " + distance);
        Debug.Log("rotDir: " + rotDir);
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime * speed;

        float x = Mathf.Cos(timeCounter) * distance;
        float y = 13;
        float z = Mathf.Sin(timeCounter) * distance;
        //  transform.position = new Vector3(x, y, z);

        if (rotDir == 0)
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 20 * Time.deltaTime * speed);
        }

        if (rotDir == 1)
        {
            transform.RotateAround(Vector3.zero, -Vector3.up, 20 * Time.deltaTime * speed);
        }

        //transform.RotateAround(Vector3.zero, -Vector3.up, 20 * Time.deltaTime);
        transform.LookAt(cameraTarget);


    }
}