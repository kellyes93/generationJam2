using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LifeCounter : MonoBehaviour
{
    [SerializeField] private int life = 3;

    public TextMeshProUGUI textLifePro;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textLifePro.text = life.ToString("f0");
        if (life < 1)
        {
            //LLAMA GAME OVER 

        }
    }

}
