using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform_Movement : MonoBehaviour
{
    public float platformSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

           transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * platformSpeed, 5), transform.position.z);
    //    transform.Translate (platformSpeed * Time.deltaTime, 0);

    }
}
