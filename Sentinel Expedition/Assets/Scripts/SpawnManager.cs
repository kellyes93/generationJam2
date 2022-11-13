using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int numberEnemy;
    public int numberAttack = 1;
    // Start is called before the first frame update
    void Start()
    {
        rightSpawn(numberAttack);
    }

    // Update is called once per frame
    void Update()
    {
        numberEnemy = FindObjectsOfType<EnemyFinding1>().Length;
        if (numberEnemy == 0)
        {
            numberAttack++;
            rightSpawn(numberAttack);
        }
    }

    void rightSpawn(int enemyAmount)
    {
        for(int i = 0; i < enemyAmount; i++)
        {
            Vector3 spawnPos = new Vector3(0, Random.Range(5, -5), 0);

            Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);

        }

    }
}
