using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using System;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverMenu;
    private PlayerDiedAnimation died;
    public AudioSource clip;
    // Start is called before the first frame update
    void Start()
    {
        died = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerDiedAnimation>();
        died.overHandler += ActivateCanvas;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void RetryLevel(string nameLevel)
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void LoadLevel(string nameLevel)
    {

        clip.Play();
        SceneManager.LoadScene(nameLevel);
    }
    private void ActivateCanvas(object sender, EventArgs e)
    {
        gameOverMenu.SetActive(true);
    }

}
