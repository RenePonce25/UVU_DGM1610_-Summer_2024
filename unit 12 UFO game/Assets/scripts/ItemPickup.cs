using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public float boxSpeed = 10f;
    private float xlimit = 40f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * boxSpeed);
      
        if (transform.position.x < -xlimit)
        {
            transform.Translate(Vector3.right * Time.deltaTime * boxSpeed);
        }
        if (transform.position.x > xlimit)
        {
            transform.Translate(Vector3.left * Time.deltaTime * boxSpeed);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
        Debug.Log("New Ammo Pickup.");
    }
}
