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

    public void FailedLevel()
    {
        // Play a sound
        GetComponent<AudioSource>().Play();
        // Load the game over scene
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