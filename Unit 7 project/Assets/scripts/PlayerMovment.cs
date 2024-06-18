using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 5f;
    public float turnSpeed;
    private float horizotalInput;
    private float forwardInput;
    void Start()
    {
      
        
    }

    // Update is called once per frame
    void Update()
    {
        // get player input
        horizotalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //move player
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up,turnSpeed * horizotalInput * Time.deltaTime);
            
        }
    }

