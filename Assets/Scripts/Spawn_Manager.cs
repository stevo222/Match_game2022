using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour
{
    public GameObject[] enemy;

    public GameObject[] miniHealth;

    private float zspawn = 0;
    private float yspawn = 5.0f;
    private float xyspwan = 8.0f;

    private float startDelay = 1.0f;
    private float MinihealthSpawnTime = 5.0f;
    private float enemySpwnTime = 2.0f;
    

    // Start is called before the first frame update
    void Start()
    {
       InvokeRepeating("SpawnEnemy",startDelay,enemySpwnTime); 
       InvokeRepeating("SpawnminiHealth",startDelay,MinihealthSpawnTime);
    }

    void SpawnEnemy()
    {
        float randomx = Random.Range(-xyspwan, xyspwan);
        int randomIndex = Random.Range(0, enemy.Length);

        Vector3 spawnPos = new Vector3(randomx, yspawn, 0);
        Instantiate(enemy[randomIndex], spawnPos, enemy[randomIndex].gameObject.transform.rotation);
    }

    void SpawnminiHealth()
    {
        float randomx = Random.Range(-xyspwan, xyspwan);
        int randomIndex = Random.Range(0, miniHealth.Length);
        
        Vector3 spawnPos = new Vector3(randomx, yspawn, 0);
        Instantiate(miniHealth[randomIndex], spawnPos, miniHealth[randomIndex].gameObject.transform.rotation);
    }
  
}
