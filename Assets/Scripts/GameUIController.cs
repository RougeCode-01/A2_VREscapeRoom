using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

public class GameUIController : MonoBehaviour
{
    // Method to load the EscapeRoom scene
    public void PlayAgain()
    {
        SceneManager.LoadScene("EscapeRoom");
    }

    // Method to load the Menu scene
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Method to quit the game
    public void QuitGame()
    {
        Application.Quit();
    }
}