using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject ExitCollider;
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
        // Check if the player has collided with the exit collider
        if (other.CompareTag("Player"))
        {
            // Load the next level
            SceneManager.LoadScene("CompleationScene");
        }
    }

    
}