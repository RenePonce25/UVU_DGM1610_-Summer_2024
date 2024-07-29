using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float xSpawn = 40f;
    public float zSpawn = 2f;
    public float fixedHeight = 1.7f;

    private float spawnInterval = 4.5f;
    private float startDelay = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUfo",startDelay,spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    private void SpawnRandomUfo()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawn,xSpawn),fixedHeight,Random.Range(-zSpawn,zSpawn));
        int enemyIndex = Random.Range(0,enemies.Length);
        Instantiate(enemies[enemyIndex],spawnPos, enemies[enemyIndex].transform.rotation);
    }
}
