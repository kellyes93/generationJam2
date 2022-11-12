using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float forwardInput;
    public float verticalInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Horizontal") * speed;
        verticalInput = Input.GetAxis("Vertical") * speed;

        transform.Translate(Vector2.right *Time.deltaTime * forwardInput);
        transform.Translate(Vector2.up * Time.deltaTime * verticalInput);
    }
}
