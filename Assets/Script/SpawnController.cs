using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public List<GameObject> ListEnemyTemplate;
    private List<GameObject> EnemyList;
    private float timerSpawn;
    public int spawnInterval, maxSpawn;

    // Start is called before the first frame update
    void Start()
    {
        EnemyList = new List<GameObject>();
        timerSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
    }

    private void SpawnEnemy()
    {
        timerSpawn += Time.deltaTime;

        if (timerSpawn > spawnInterval )
        {
            if (EnemyList.Count < maxSpawn)
            {
                GenerateRandom();
            }

            timerSpawn -= spawnInterval;
        }
    }

    private void GenerateRandom()
    {
        int randomIndex = UnityEngine.Random.Range(0, ListEnemyTemplate.Count);
        GameObject Enemy = Instantiate(ListEnemyTemplate[randomIndex]);
        Enemy.SetActive(true);
        EnemyList.Add(Enemy);
    }

    public void removeEnemy(GameObject enemy)
    {
        EnemyList.Remove(enemy);
        Destroy(enemy);
    }

    
}
