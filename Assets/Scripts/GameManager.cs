using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartLevel();
        }
    }
    
    public void RestartLevel()
    {
        SceneManager.LoadScene("EscapeRoom");
    }

    private void FailedLevel()
    {
        //if the timer runs out
        //Fail the player
        //Play a sound
        //Load the game over scene
        SceneManager.LoadScene("GameOverScene");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene("CompleationScene");
        }
    }
}