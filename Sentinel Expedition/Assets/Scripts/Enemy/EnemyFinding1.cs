using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToEnemy : MonoBehaviour
{
    public float life;
    public GameObject diedEffect;
    public ScorePoints score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Player").GetComponent<ScorePoints>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage (float damage)
    {
        life -= damage;
        if (life <= 0)
        {
            Died();
        }
        
    }

    private void Died()
    {
        Instantiate(diedEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);    
    }
}
