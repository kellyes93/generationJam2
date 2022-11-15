using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour
{

    public PlayerDiedAnimation life;
    public Image statusBar;
    public float maxLife;
    // Start is called before the first frame update
    void Start()
    {
        life = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDiedAnimation>();
        maxLife = life.pointsLifePlayer;
    }

    // Update is called once per frame
    void Update()
    {
        //Counter life in the HUD
        statusBar.fillAmount = life.pointsLifePlayer / maxLife;

        if (life.pointsLifePlayer <= 0)
        {
            //Call GAME OVER 
            Debug.Log("GAME OVER");

        }
    }

}
