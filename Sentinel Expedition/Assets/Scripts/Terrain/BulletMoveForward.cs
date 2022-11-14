using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveForward : MonoBehaviour
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
        if(other.CompareTag("Enemy"))
        {
            other.GetComponent<EnemyFinding1>().TakeDamage(damage);
            Destroy(this.gameObject);
        }   
    }
}
