using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StockCounter : MonoBehaviour
{
    public int wood = 2;
    public int stones = 10;
    public TextMeshProUGUI textStonesCounter;
    public TextMeshProUGUI textWoodCounter;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textStonesCounter.text = stones.ToString("f0");
        textWoodCounter.text = wood.ToString("f0");
    }
}
