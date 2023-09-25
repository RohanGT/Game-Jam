using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelPass : MonoBehaviour
{
    public GameObject gameOverText;
    private void Start()
    {
        if (gameOverText)
        {
            gameOverText.SetActive(false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (SceneManager.GetActiveScene().buildIndex <= 3)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                gameOverText.SetActive(true);
            }
        }

    }
}
