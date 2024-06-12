using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] public float moveSpeed = 5f;

    [SerializeField] public float Jumping = 5f;
    // Start is called before the first frame update
    void Start()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0,0,moveSpeed * Time.deltaTime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
