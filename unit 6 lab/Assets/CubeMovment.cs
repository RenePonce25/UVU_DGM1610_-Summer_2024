using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovment : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000f;
    public float sideWaysForce = 500f;
    public float jumpForce = 1000f;
    void Update()
    {
       
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,forwardForce * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideWaysForce * Time.deltaTime,0,0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideWaysForce * Time.deltaTime,0,0);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0,0,-sideWaysForce * Time.deltaTime);
        }
        if (Input.GetKey("j"))
        {
            rb.AddForce(0,jumpForce * Time.deltaTime,0);
        }
    }
}
