
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;


    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            Debug.Log("Game Over");
            gameHasEnded = true;
            //add delay when loading the scene again
            Invoke("Restart", 2f);

        }

    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

    public void CompleteLevel2()
    {

        Debug.Log("Load Level 2");
        // SceneManager.LoadScene("Level2");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
