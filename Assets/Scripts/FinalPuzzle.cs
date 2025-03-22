using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class FinalPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject doorToOpen;

    void Update()
    {
        if (ScaleOne.scaleOneCorrect && ScaleTwo.scaleTwoCorrect && ScaleThree.scaleThreeCorrect)
        {
            OpenDoor();
        }
    }

    private void OpenDoor()
    {
        // Open the door by enabling the XR interactable component
        doorToOpen.GetComponent<XRBaseInteractable>().enabled = true;
        // Play a sound
        doorToOpen.GetComponent<AudioSource>().Play();
    }
}