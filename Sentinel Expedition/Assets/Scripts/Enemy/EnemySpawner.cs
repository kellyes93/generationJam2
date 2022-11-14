using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject cannibalPrefab;
    [SerializeField] private float cannibalInterval = 1.5f;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy(cannibalInterval, cannibalPrefab));
        
    }

    // Update is called once per frame
    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, new Vector3(Random.Range(-5f, 5), Random.Range(-6f, 6f), 0), Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));

    }
}
