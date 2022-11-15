using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageToEnemy : MonoBehaviour
{
    public float life;
    public GameObject diedEffect;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage (float damage)
    {
        //Method to knock de enemy
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
