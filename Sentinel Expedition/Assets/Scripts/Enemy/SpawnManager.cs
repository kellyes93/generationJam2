using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public int numberEnemy;
    public int numberAttack = 1;
    public float delayInterval = 0;
    public float interval = 10;
    public bool starSpawn = true;
    public Transform[] spawnPoints;
    // Start is called before the first frame update
    void Start()
    {
        rightSpawn(numberAttack);
    }

    // Update is called once per frame
    void Update()
    {
        //Method to increase an enemy in each wave, time between waves and stop waves
        numberEnemy = FindObjectsOfType<EnemyFinding1>().Length;
        if (numberEnemy == 0 && delayInterval < Time.time && starSpawn == true)
        {
            delayInterval = Time.time + interval;
            numberAttack++;
            rightSpawn(numberAttack);
            
        }
        else if (numberEnemy == 11)
        {

            SceneManager.LoadScene("Final");
            starSpawn = false;


        }
    }

    void rightSpawn(int enemyAmount)
    {
        //This allows to create random positions in the map
        for (int i = 0; i < enemyAmount; i++)
        {
            Vector3 spawnPos = new Vector3(9, Random.Range(5, -5), 0); 
            Transform _sp = spawnPoints[Random.Range(0, spawnPoints.Length)];
            Instantiate(enemyPrefab, _sp.position, _sp.rotation);

        }

    }

}
