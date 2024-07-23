using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float projectileSpeed = 20;
    public float zLimit = 30f;
    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * projectileSpeed);

        if (transform.position.z < zLimit)
        {
            Destroy(gameObject);
        }
        
    }

    public void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
