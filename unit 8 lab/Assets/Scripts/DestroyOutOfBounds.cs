using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float destroyBoundryTop = 40;
    private float destroyBoundryBottom = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > destroyBoundryTop)
        {
            Destroy(gameObject);
        } else if (transform.position.z < destroyBoundryBottom)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        
    }
}
