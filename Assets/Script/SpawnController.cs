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
        EnemyList = new List<GameObject>;
        timerSpawn = 0;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnEnemy();
        //StartCoroutine(SpawnInit());
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

            spawnInterval
        }
    }

    private void GenerateRandom()
    {
        
    }

    /*IEnumerator SpawnInit()
    {
        float spawnX = Random.Range(-6, 6);
        Vector3 spawnPosition = new Vector3(spawnX, 6, 0);

        Instantiate(Enemy, spawnPosition, Quaternion.identity);

        yield return new WaitForSeconds(10);

    }*/
}
