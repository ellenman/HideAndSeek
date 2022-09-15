using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit the game");
    }

    public void StartGame()
    {
        //load the sample scene when we press the start game button 
        SceneManager.LoadScene("Scenes/SampleScene");
    }
}
