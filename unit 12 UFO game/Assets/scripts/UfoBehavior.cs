using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UfoBehavior : MonoBehaviour
{
    public float ufoSpeed = 10f;
    private float xlimit = 40f;
    private Vector3 move = Vector3.right;
    
    public ScoreManager scoreManager;
    public int scoreToGive;

     void Start()
    {
        scoreManager = GameObject.Find("Score Manager").GetComponent<ScoreManager>();
    }

    void Update()
    {
        transform.Translate(move * Time.deltaTime * ufoSpeed);
      
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
        scoreManager.IncreaseScore(scoreToGive);
        Destroy(gameObject);
       
    }
}
