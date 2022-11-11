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
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    // Update is called once per frame
    void Update()
    {
        TargetFollow ();
        FlipSprite ();
    }

    void TargetFollow ()
    {
        if (Vector2.Distance(transform.position, target.position) > targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }

    void FlipSprite ()
    {
        if (playerTransform.position.x > transform.position.x)
        {
            //Turn face right
            transform.localScale = new Vector3(1, 1, 1);
        } 
        else if (playerTransform.position.x < transform.position.x)
        {
            //Turn face left
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
