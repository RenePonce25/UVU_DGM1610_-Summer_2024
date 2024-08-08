using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10f;
    private float move;
    private float xlimit = 40f;
    
    public ParticleSystem fireAnimation;
    public AudioClip fireSound;
    private AudioSource playerAudio;

    public Transform fireCannon;
    public GameObject projectile;
  
    
    // Start is called before the first frame update
    void Start()
    {
       
        playerAudio = GetComponent<AudioSource>();
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
            fireAnimation.Play();
            playerAudio.PlayOneShot(fireSound, 20.0f);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        
    }
}
