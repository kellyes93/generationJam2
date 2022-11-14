using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int numberEnemy;
    public int numberAttack = 1;
    public float delayInterval = 0;
    public float interval = 10;
    // Start is called before the first frame update
    void Start()
    {
        rightSpawn(numberAttack);
    }

    // Update is called once per frame
    void Update()
    {
        numberEnemy = FindObjectsOfType<EnemyFinding1>().Length;
        if (numberEnemy == 0 && delayInterval < Time.time)
            {
                numberAttack++;
                rightSpawn(numberAttack);
                delayInterval = Time.time + interval;            
            }
        else if (numberEnemy == 3)
        {
            Debug.Log("Final");
            StopAllCoroutines();
        }
    }

    void rightSpawn(int enemyAmount)
    {
        for(int i = 0; i < enemyAmount; i++)
        {
            Vector3 spawnPos = new Vector3(9, Random.Range(5, -5), 0);

            Instantiate(enemyPrefab, spawnPos, enemyPrefab.transform.rotation);

        }

    }

}
