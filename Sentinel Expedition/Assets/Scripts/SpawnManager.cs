using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float startDelay = 2;
    private float spawnDelay = 0.5f;
    public int numberEnemy;
    // Start is called before the first frame update
    void Start()
    {
        rightSpawn(3);
    }

    // Update is called once per frame
    void Update()
    {
        numberEnemy = FindObjectsOfType<EnemyMove>().Length;
        if (numberEnemy == 0)
        {
            rightSpawn(3);
        }
    }

    void rightSpawn(int enemyAmount)
    {
        for(int i = 0; i < enemyAmount; i++)
        {
            int enemyIndex = Random.Range(0, enemyPrefabs.Length);
            Vector3 spawnPos = new Vector3(0, 0, 0);

            Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);

        }

    }
}
