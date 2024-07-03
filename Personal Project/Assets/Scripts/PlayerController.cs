using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 20;
    public float jumpForce = 30;
    private bool isOnGround = true;
    public Rigidbody playerRb;

    private float zBound = 50f;
    private float xBound = 50f;
    void Start()
    {
        playerRb.GetComponent<Rigidbody>();
    }

   
    void Update()
    {
        float horizontalMovment = Input.GetAxis("Horizontal");
        float verticalIMovment = Input.GetAxis("Vertical");
        
        playerRb.AddForce(Vector3.forward * moveSpeed * verticalIMovment);
        playerRb.AddForce(Vector3.right * moveSpeed * horizontalMovment);
        
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
           playerRb.AddForce(Vector3.up * jumpForce,ForceMode.Impulse);
           isOnGround = false;
        }
        //player boundries
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        
        if (transform.position.x < -xBound)
        {
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xBound)
        {
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);
        }
    }
    
}
