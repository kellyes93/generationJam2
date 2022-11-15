using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Pause : MonoBehaviour
{
    public GameObject pause;
    public bool isPaused;
    public AudioSource clip;
    // Start is called before the first frame update
    void Start()
    {
        pause.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }

            // isPaused ? ResumeGame : PauseGame;
        }
        //isPaused ? ResumeGame() : PauseGame();
    }

    public void PauseGame()
    {
        pause.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
        clip.Play();
    }

    public void ResumeGame()
    {
        pause.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
        clip.Play();
    }

    public void GoToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Menu");
        clip.Play();

    }
}
