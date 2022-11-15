using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float move;
    public float moveY;
    private float xRange = 8.0f;
    private float yRange = 3.0f;
    [Header("Animation")]
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        StopLimit();

        move = Input.GetAxis("Horizontal");
        animator.SetFloat("Horizontal", move);

        //Same value on Horizontal Axis
        moveY = Input.GetAxis("Vertical");
        animator.SetFloat("Vertical", moveY);
        transform.Translate(Vector2.right * move * Time.deltaTime * speed);
        transform.Translate(Vector2.up * moveY * Time.deltaTime * speed);

    }

    void StopLimit ()
    {
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector2 (-xRange, transform.position.y);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector2 (xRange, transform.position.y);
        }

        if (transform.position.y < -yRange)
        {
            transform.position = new Vector2 (transform.position.x, -yRange);
        }

        if (transform.position.y > yRange)
        {
            transform.position = new Vector2 (transform.position.x, yRange);
        }
    }

}