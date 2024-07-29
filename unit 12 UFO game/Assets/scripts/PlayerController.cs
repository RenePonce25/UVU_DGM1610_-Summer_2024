using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private float move;
    private float xlimit = 40f;
    private Rigidbody playerRb;
    public ParticleSystem fireAnimation;

    public Transform fireCannon;
    public GameObject projectile;
  
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        move = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * move* Time.deltaTime * speed);

        if (transform.position.x < -xlimit)
        {
            transform.position = new Vector3(-xlimit, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xlimit)
        {
            transform.position = new Vector3(xlimit, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Instantiate(projectile, fireCannon.transform.position, projectile.transform.rotation);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
