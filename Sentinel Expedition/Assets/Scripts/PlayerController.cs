using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float move;
    public float movey;
    public float xRange = 8.0f;
    public float yRange = 3.0f;
    public GameObject bulletRocks;
    public Transform spawnRockPosition;
    //private Rigidbody2D rigidPlayer;
    //public float force;
    /*Mouse follow*/
    public Vector3 turn;
    public float sensitivity = .5f;

    [Header("Animation")]
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        //rigidPlayer = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        StopLimit();
        ShootPlayer();

        move = Input.GetAxis("Horizontal") * speed;
        animator.SetFloat("Horizontal",move);
        //mismo valor del axis horizontal lo guarda de acuerdo al imput
        movey = Input.GetAxis("Vertical") * speed;
        animator.SetFloat("Vertical",movey);
        transform.Translate(move * Time.deltaTime, 0, 0);
        transform.Translate(0, movey * Time.deltaTime, 0);


        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;

        //transform.localRotation = Quaternion.Euler(- turn.x,0,0);
        // translada de derecha o izquierda de acuerdo al valor almacenado en move.

        /* if(Input.GetKeyDown("Jump"){
             //Debug.Log("ENTRO");
             rigidPlayer.AddForce(Vector2.up * force, ForceMode.Impulse); //añade una fuerza hacia arriba
         }*/
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

    void ShootPlayer ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(bulletRocks, spawnRockPosition.position, bulletRocks.transform.rotation);
            }
    }

    /*private void Awake() {
        aimTransform = transform.Find("Aim")
    }*/
}

/*
void DestroyBlock()
if(other.gameObject.CompareTag("Mazo")
{
Invoke ("DestroyBlock", 0.8f)
}

*/