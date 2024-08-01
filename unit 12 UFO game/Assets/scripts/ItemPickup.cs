using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public float boxSpeed = 10f;
    private float xlimit = 52f;
    private Vector3 move = Vector3.left;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(move * Time.deltaTime * boxSpeed);
      
        if (transform.position.x < -xlimit)
        {
           Destroy(gameObject);
        }
      
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("New Ammo Pickup.");
       
    }
}
