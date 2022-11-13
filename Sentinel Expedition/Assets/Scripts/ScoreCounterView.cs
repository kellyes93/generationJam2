using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreCounterView : MonoBehaviour
{
    public float score = 0;
    public TextMeshProUGUI textScorePro;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        score += 1 * Time.deltaTime;
        textScorePro.text = "score: " + score.ToString("f0");

        if (score <= 0)
        {
            textScorePro.text = "score";
        }

    }
}
