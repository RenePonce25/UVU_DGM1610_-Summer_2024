using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TtPlayerMovment : MonoBehaviour
{
    public float horizotalMovement;
    public float speed = 10f;
    public float xRange = 20;

    public GameObject projectilePrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        horizotalMovement = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizotalMovement * Time.deltaTime *speed);

        if (Input.GetKeyDown(KeyCode.Space))
        {
           //launch pizza from player
           Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
