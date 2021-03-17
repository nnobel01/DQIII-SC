using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour
{
   public void _startGame(string scene_name)
    {
        SceneManager.LoadScene(scene_name);
    }

    public void _quitGame()
    {
        Application.Quit();

        Debug.Log("Game is Quitting");
    }
}
