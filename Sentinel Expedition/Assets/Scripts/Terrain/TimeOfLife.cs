using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeOfLife : MonoBehaviour
{
    [SerializeField] private float timeOfLife;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, timeOfLife);
    }


}
