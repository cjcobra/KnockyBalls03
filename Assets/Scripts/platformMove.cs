using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMove : MonoBehaviour
{

    public float speed = 2.5f;
  //  float myTimer;

    // Start is called before the first frame update
    void Start()
    {
  //      myTimer = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);

    //    transform.position = new Vector3 (Mathf.PingPong(myTimer = speed, 5), transform.position.y, transform.position.z);

    }
}
