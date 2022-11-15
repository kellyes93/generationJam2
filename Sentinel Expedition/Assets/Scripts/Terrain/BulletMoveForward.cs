using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class BulletMoveForward : MonoBehaviour
{

     
    public AudioSource clip;
  
    public float damage;
    public ScorePoints score;
    // Start is called before the first frame update
    void Start()
    {
        //Allows you to see the number of points the player makes with each shot
        score = GameObject.FindGameObjectWithTag("Player").GetComponent<ScorePoints>();
        
        clip.Play();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        //If the rock hits the enemy, knock them. 
        
        if(other.CompareTag("Enemy"))
        {
            
            other.GetComponent<EnemyFinding1>().TakeDamage(damage);
            
            Destroy(this.gameObject);
            
            score.score ++;
        }   
    }
}
