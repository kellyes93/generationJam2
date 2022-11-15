using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    public GameObject player;
    public Transform respawnPoint;
    private PlayerDiedAnimation playerLife;
    // Start is called before the first frame update
    void Start()
    {
        playerLife = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDiedAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        //Condition to take damage and died if the enemt touch the player
        if(other.gameObject.CompareTag("Player"))
        {
            player.transform.position = respawnPoint.position;
        }    
    }
}
