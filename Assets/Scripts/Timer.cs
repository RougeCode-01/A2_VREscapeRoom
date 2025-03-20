using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 300f;
    public Text timerText;
    public GameManager gameManager;

    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            UpdateTimerText();
        }
        else
        {
            timeRemaining = 0;
            gameManager.FailedLevel();
        }
    }

    void UpdateTimerText()
    {
        TimeSpan timeSpan = TimeSpan.FromSeconds(timeRemaining);
        timerText.text = string.Format("{0:D2}:{1:D2}", timeSpan.Minutes, timeSpan.Seconds);
    }
}