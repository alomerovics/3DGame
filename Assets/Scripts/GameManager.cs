using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool isEndGame = false;
    public float restartDelay = 1f;

    public void CompleteLevel()
    {
    
    }

    public void EndGame()
    {
        if (isEndGame == false)
        {
            isEndGame = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
