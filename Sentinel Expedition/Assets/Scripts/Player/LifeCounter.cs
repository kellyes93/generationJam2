using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LifeCounter : MonoBehaviour
{

    //[SerializeField] private int life = 3;
    public PlayerDiedAnimation life;

    //public TextMeshProUGUI textLifePro;
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
        statusBar.fillAmount = life.pointsLifePlayer / maxLife;
        //textLifePro.text = life.pointsLifePlayer.ToString("f0");
        if (life.pointsLifePlayer <= 0)
        {
            //LLAMA GAME OVER 
            Debug.Log("GAME OVER");

        }
    }

}
