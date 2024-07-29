using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public float boxSpeed = 10f;
    private float xlimit = 40f;
    private Vector3 move = Vector3.right;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(move * Time.deltaTime * boxSpeed);
      
        if (transform.position.x < -xlimit)
        {
            move = Vector3.right;
        }
        if (transform.position.x > xlimit)
        {
            move = Vector3.left;
            Debug.Log("your mom");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Debug.Log("New Ammo Pickup.");
       
    }
}
