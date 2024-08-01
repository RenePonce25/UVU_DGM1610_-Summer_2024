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
    public GameObject[] pickups;

    private float spawnInterval = 4.5f;
    private float startDelay = 2f;

    private void Start()
    {
        InvokeRepeating("SpawnRandomUfo",startDelay,spawnInterval);
        InvokeRepeating("SpawnPickUps",startDelay,spawnInterval);
    }
    private void SpawnRandomUfo()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-xSpawn,xSpawn),fixedHeight,Random.Range(-zSpawn,zSpawn));
        int enemyIndex = Random.Range(0,enemies.Length);
        Instantiate(enemies[enemyIndex],spawnPos, enemies[enemyIndex].transform.rotation);
    }

    private void SpawnPickUps()
    {
        Vector3 spawnItem = new Vector3(50, 1, 10);
        int pickUpsIndex = Random.Range(0, pickups.Length);
        Instantiate(pickups[pickUpsIndex], spawnItem, pickups[pickUpsIndex].transform.rotation);
    }
    
}
