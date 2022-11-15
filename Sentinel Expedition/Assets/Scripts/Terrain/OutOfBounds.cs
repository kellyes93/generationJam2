using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public float limit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //When the bullet crosses the limit it is destroyed 
        if (transform.position.x > limit)
        {
            Destroy(gameObject);
        }
    }
}
