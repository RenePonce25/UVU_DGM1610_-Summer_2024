using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneControls : MonoBehaviour
{
    public Rigidbody plane;
    public float planeSpeed = 200f;
    public float pitchSpeed;
    public float turnSpeed;
    private float forwardMovment = 1000f;
    private float turningMovment; 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        turningMovment = Input.GetAxis("Horizontal");
       
        plane.AddForce(0,0,forwardMovment * Time.deltaTime);
        transform.Rotate(Vector3.up,forwardMovment * turningMovment * Time.deltaTime );
    }
}
