using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float forwardInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector2.right *Time.deltaTime * speed * forwardInput);
    }
}
