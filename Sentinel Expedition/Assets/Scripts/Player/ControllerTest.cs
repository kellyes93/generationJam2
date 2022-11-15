using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerTest : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [Header("Move")]
    private float inputForward = 0f;
    public float speed;
    public float smooth;
    private Vector3 velocity = Vector3.zero;
    private bool isRight = true;
    private Animator animator;



    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void update()
    {
        inputForward = Input.GetAxisRaw("Horizontal") * speed;
        animator.SetFloat("Horizontal", inputForward); 

    }

    private void FixedUpdate() 
    {
        Move(inputForward * Time.deltaTime);
    }

    private void Move(float moving)
    {
        Vector3 velocityObj = new Vector2(moving, rb2D.velocity.y);
        rb2D.velocity = Vector3.SmoothDamp(rb2D.velocity, velocityObj, ref velocity, smooth);

        if (moving > 0 && !isRight)
        {
            turn();
        }
        else if (moving < 0 && isRight)
        {
            turn();
        }
    }

    private void turn ()
    {
        isRight = !isRight;
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }

}
