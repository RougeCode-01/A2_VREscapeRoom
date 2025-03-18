using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SimonSays : MonoBehaviour
{
    [SerializeField] private List<Color> colorSequence = new List<Color>();
    [SerializeField] private Renderer[] colorRenderers; // Assign the renderers in the Inspector
    [SerializeField] private float colorDisplayTime = 1.0f;
    [SerializeField] private float colorPauseTime = 0.5f;
    [SerializeField] private int rounds = 3;

    private int currentRound = 0;
    private int playerIndex = 0;
    private bool playerTurn = false;

    void Start()
    {
        StartCoroutine(StartSimonSays());
    }

    IEnumerator StartSimonSays()
    {
        for (int i = 0; i < rounds; i++)
        {
            currentRound++;
            AddRandomColorToSequence();
            yield return StartCoroutine(DisplayColorSequence());
            playerTurn = true;
            yield return new WaitUntil(() => playerIndex >= colorSequence.Count);
            playerTurn = false;
            playerIndex = 0;
        }
        // Game completed, reveal the final puzzle piece or any other action
    }

    void AddRandomColorToSequence()
    {
        Color randomColor = colorRenderers[Random.Range(0, colorRenderers.Length)].material.color;
        colorSequence.Add(randomColor);
    }

    IEnumerator DisplayColorSequence()
    {
        foreach (Color color in colorSequence)
        {
            foreach (Renderer renderer in colorRenderers)
            {
                if (renderer.material.color == color)
                {
                    renderer.enabled = true;
                    yield return new WaitForSeconds(colorDisplayTime);
                    renderer.enabled = false;
                    yield return new WaitForSeconds(colorPauseTime);
                }
            }
        }
    }

    public void PlayerInput(Color color)
    {
        if (playerTurn && colorSequence[playerIndex] == color)
        {
            playerIndex++;
        }
        else
        {
            // Player made a mistake, handle accordingly
            playerIndex = 0;
        }
    }
}