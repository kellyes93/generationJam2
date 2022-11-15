using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounterView : MonoBehaviour
{
    // public float score = 0;
    public ScorePoints currentScore;
    public TextMeshProUGUI textScorePro;
    // Start is called before the first frame update
    void Start()
    {
        currentScore = GameObject.FindGameObjectWithTag("Player").GetComponent<ScorePoints>();
    }

    // Update is called once per frame
    void Update()
    {
        //score += 1 * Time.deltaTime;
        textScorePro.text = "score: " + currentScore.score.ToString("f0");

        if (currentScore.score <= 0)
        {
            textScorePro.text = "score : 0";
        }

    }
}
