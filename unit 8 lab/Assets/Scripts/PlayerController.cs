using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public Rigidbody player;
    public float speed = 10f;
    public float xRange = 20;
    public float zRange = 20;

    public GameObject projectilePrefab;
  
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //player boundry
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.z < -zRange)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,-zRange);
        }
        if (transform.position.z > zRange)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,zRange);
        }

        //player movmemt
        horizontalInput = Input.GetAxis("Horizontal");
        
    }

    private void FixedUpdate()
    {
        player.AddForce(Vector3.right * horizontalInput * speed);
    }
}
