using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float speed = 5f;
    private float horizotalInput;
    private float forwardInput;
    public float jumpHeight = 5f;
    
    private Rigidbody playerRB;
    public bool isOnGround = true;

    public KeyCode sprintKey = KeyCode.LeftShift;
    public KeyCode crouchKey = KeyCode.LeftControl;
    
    public float crouchSpeed;
    public float crouchYscale;
    private float startYscale;
    
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();

        startYscale = transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        // gut player input
        horizotalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        //move player
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizotalInput);

       
        
        //let player jump
        if (Input.GetKeyDown(KeyCode.Space)&& isOnGround) 
        {
            playerRB.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            isOnGround = false;
        }
        //start crouch
        if (Input.GetKeyDown(crouchKey))
        {
            transform.localScale = new Vector3(transform.localScale.x, crouchYscale, transform.localScale.z);
            playerRB.AddForce(Vector3.down * 5f, ForceMode.Impulse);
            
            //stop crouching
            if (Input.GetKeyUp(crouchKey))
            {
                transform.localScale = new Vector3(transform.localScale.x, startYscale, transform.localScale.z);
                
            }
            //sprint
        }
    }
}
