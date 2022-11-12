using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float move;
    private float movey;
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
        move = Input.GetAxis("Horizontal");
        animator.SetFloat("Horizontal",move);
        //mismo valor del axis horizontal lo guarda de acuerdo al imput
        movey = Input.GetAxis("Vertical");
        animator.SetFloat("Vertical",movey);
        transform.Translate(move * speed, 0, 0);
        transform.Translate(0, movey * speed, 0);


        turn.x += Input.GetAxis("Mouse X") * sensitivity;
        turn.y += Input.GetAxis("Mouse Y") * sensitivity;

        transform.localRotation = Quaternion.Euler(- turn.x,0,0);
        // translada de derecha o izquierda de acuerdo al valor almacenado en move.

        /* if(Input.GetKeyDown("Jump"){
             //Debug.Log("ENTRO");
             rigidPlayer.AddForce(Vector2.up * force, ForceMode.Impulse); //añade una fuerza hacia arriba
         }*/
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