using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBasicEnemies : MonoBehaviour
{
    public GameObject[] enemies;
    private float zEnemySpawn = 50f;
    private float xEnemySpawn = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-zEnemySpawn, zEnemySpawn);
        int randomIndex = Random.Range(0, enemies.Length);
        Vector3 spawnPos = new Vector3(randomX, 1, zEnemySpawn);
        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);
    }
}
