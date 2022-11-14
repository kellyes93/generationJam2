using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
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
        SceneManager.LoadScene(nameLevel);
    }


}
