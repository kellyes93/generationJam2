using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TimeOfLife : MonoBehaviour
{
    
    public float timeOfLife;
    public AudioSource clip;
    // Start is called before the first frame update
    void Start()
    {
        clip.Play(); 
        Destroy(gameObject, timeOfLife);
       
    }


}
