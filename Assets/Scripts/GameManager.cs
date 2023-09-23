using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameRunning = true;
    public void GameOver()
    {
        if(gameRunning)
        {
            gameRunning = false;
            Debug.Log("Game Over");
            Invoke("Restart", 1);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}