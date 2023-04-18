using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        int index = SceneManager.GetActiveScene().buildIndex - 1;
        ScoreManager.points = 0;
        SceneManager.LoadScene(index);
    }
}
