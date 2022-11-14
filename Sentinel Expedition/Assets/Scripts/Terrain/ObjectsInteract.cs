using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsInteract : MonoBehaviour
{
    public Inventary inventary;
    // Start is called before the first frame update
    void Start()
    {
        inventary = GameObject.FindGameObjectWithTag("SecondPlayer").GetComponent<Inventary>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "SecondPlayer")
        {
            inventary.amount += 1;
            Destroy(gameObject);
        }
    }
}
