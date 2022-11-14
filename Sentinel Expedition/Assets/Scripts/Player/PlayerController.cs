using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float move;
    public float movey;
    private float xRange = 8.0f;
    private float yRange = 3.0f;
    private bool lookingRigt = true;
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

        move = Input.GetAxis("Horizontal") * speed;
        animator.SetFloat("Horizontal",move);
        //mismo valor del axis horizontal lo guarda de acuerdo al imput
        movey = Input.GetAxis("Vertical") * speed;
        animator.SetFloat("Vertical",movey);
        transform.Translate(move * Time.deltaTime, 0, 0);
        transform.Translate(0, movey * Time.deltaTime, 0);


        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;

        if (move > 0 && !lookingRigt)
        {
            //Turn
            //Turn();
        }
        else if (move < 0 && lookingRigt)
        {
            //Turn
            //Turn();
        }

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


    void Turn ()
    {
        lookingRigt = !lookingRigt;
        transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180, 0);
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