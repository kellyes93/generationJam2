using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageToPlayer : MonoBehaviour
{
    public float damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        //Condition to hurt de Player
        if(other.CompareTag("Player"))
        {
            other.GetComponent<PlayerDiedAnimation>().TakeDamage(damage);
        }   
    }    
}
