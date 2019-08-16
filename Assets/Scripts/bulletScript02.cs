using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript02 : MonoBehaviour
{
    public float expiryTime = 0f;
    public float speed = 10f;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.forward * speed;
        Destroy(gameObject, expiryTime);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
