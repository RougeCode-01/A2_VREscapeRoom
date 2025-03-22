using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private AudioSource LoseSound;
    
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
            LoseSound.Play();
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