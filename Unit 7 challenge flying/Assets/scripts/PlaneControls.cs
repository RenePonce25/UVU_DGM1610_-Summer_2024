using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControls : MonoBehaviour
{
    public float throttleSpeed = 0.1f;
    public float maxThrust = 200f;
    public float responsiveness = 10f;

    private float throttle;
    private float roll;
    private float pitch;
    private float yaw;

    private float responseMod {
        get
        {
            return (rb.mass / 10f) * responsiveness;
        }
    }

    private Rigidbody rb;
    [SerializeField] Transform propeller;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void HandleInputs()
    {
        roll = Input.GetAxis("Roll");
        pitch = Input.GetAxis("Pitch");
         yaw= Input.GetAxis("Yaw");

         if (Input.GetKey(KeyCode.Space)) throttle += throttleSpeed;
         else if (Input.GetKey(KeyCode.LeftControl)) throttle -= throttleSpeed;
         throttle = Mathf.Clamp(throttle, 0f, 100f);
         
    }

    private void Update()
    {
       HandleInputs();
       propeller.Rotate(0, 0, 0.1f * throttle);
    }

    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * maxThrust * throttle);
        rb.AddTorque(transform.up * yaw * responseMod);
        rb.AddTorque(transform.right * pitch * responseMod);
        rb.AddTorque(-transform.forward * roll * responseMod);
    }
}
