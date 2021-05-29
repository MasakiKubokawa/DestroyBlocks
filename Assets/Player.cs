using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    float accel = 1.0f;
    Rigidbody rb;

    public  GameObject  Ball ;

    public GameObject ballPosition;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right *Input.GetAxisRaw("Horizontal")* accel,ForceMode.Impulse);
        if (Input.GetKeyDown("space")) 
        {
            Instantiate(Ball, ballPosition.transform.position,
                ballPosition.transform.rotation);
        }

    }
}
