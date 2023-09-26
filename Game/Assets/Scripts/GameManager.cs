using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameRunning = true;
    public string startText = "";
    public FloatingTextModifier playerText;
    public GameObject gameOverText;
    public void GameOver()
    {
        if(gameRunning)
        {
            gameRunning = false;
            gameOverText.SetActive(true);
            Invoke("Restart", 3);
        }
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverText.SetActive(false);
    }

    private void Start()
    {
        if (gameOverText)
        {
            gameOverText.SetActive(false);
        }
        
        if(playerText)
        {
            playerText.ChangeText(startText);
        }
    }
}
