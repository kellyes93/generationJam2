using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePlayer : MonoBehaviour
{
    public float speed;
    public float targetPosition;
    [SerializeField] Transform playerTransform;
    Rigidbody2D myRB;
    Transform target;
    [Header("Animation")]
    private Animator animator;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        animator = GetComponent<Animator>();
        playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        TargetFollow();
        animator.SetFloat("Horizontal", (playerController.move));
        animator.SetFloat("Vertical", (playerController.moveY));
    }

    void TargetFollow()
    {
        
        if (Vector2.Distance(transform.position, target.position) > targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }    

    }
    
}
