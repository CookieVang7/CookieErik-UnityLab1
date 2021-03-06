using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSSpawn : MonoBehaviour
{
    [SerializeField] private float secondsPerSpawn;
    [SerializeField] private Transform spawnLocation;
    [SerializeField] private GameObject[] enemies;

    private float lastSpawnTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (secondsPerSpawn > 0.5)
        {
            secondsPerSpawn -= (0.05f * Time.deltaTime);
        }

        if(Time.time - lastSpawnTime >= secondsPerSpawn && FPSPlayer.instance.ShouldSpawn(spawnLocation.position)){
            lastSpawnTime = Time.time;
            Spawn();
        }
    }

    private void Spawn()
    {
        GameObject enemyPrefab = enemies[Random.Range(0, enemies.Length)];
        GameObject newEnemy = Instantiate(enemyPrefab);
        newEnemy.transform.position = spawnLocation.position;
    }
}
