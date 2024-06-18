using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovment : MonoBehaviour
{
    public float carSpeed = 20f;
    public float turnSpeed;
    public float horizontalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
       //move car
       transform.Translate(Vector3.forward * Time.deltaTime * carSpeed);
       transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);
    }
}
