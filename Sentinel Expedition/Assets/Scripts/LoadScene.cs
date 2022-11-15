using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class LoadScene : MonoBehaviour
{
    public AudioSource clip;
    void Start()
    {

    }
    void Update()
    {
        //SceneManager.LoadScene("Level1");
    }
    // Start is called before the first frame update
    public void LoadLevel(string nameLevel)
    {
        Debug.Log("entro");
        clip.Play();
        SceneManager.LoadScene(nameLevel);
    }


}
