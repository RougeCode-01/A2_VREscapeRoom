using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class FinalPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject scaleOne;
    [SerializeField] private GameObject scaleTwo;
    [SerializeField] private GameObject scaleThree;
    [SerializeField] private GameObject doorToOpen;
    [SerializeField] private Vector3 doorOpenPosition; 
    [SerializeField] private Vector3 scaleDownPosition;

    private bool scaleOneCorrect = false;
    private bool scaleTwoCorrect = false;
    private bool scaleThreeCorrect = false;

    void Update()
    {
        if (scaleOneCorrect == true && scaleTwoCorrect == true && scaleThreeCorrect == true)
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

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PuzzlePieceOne"))
        {
            // Change color of scaleOne
            scaleOne.GetComponent<Renderer>().material.color = Color.green;
            // Move the scale down
            scaleOne.transform.position = scaleDownPosition;
            // Play a sound
            scaleOne.GetComponent<AudioSource>().Play();
            scaleOneCorrect = true;
            Debug.Log(scaleOneCorrect);
        }
        else if (other.gameObject.CompareTag("PuzzlePieceTwo"))
        {
            // Change color of scaleTwo
            scaleTwo.GetComponent<Renderer>().material.color = Color.green;
            // Move the scale down
            scaleTwo.transform.position = scaleDownPosition;
            // Play a sound
            scaleTwo.GetComponent<AudioSource>().Play();
            scaleTwoCorrect = true;
            Debug.Log(scaleTwoCorrect);
        }
        else if (other.gameObject.CompareTag("PuzzlePieceThree"))
        {
            // Change color of scaleThree
            scaleThree.GetComponent<Renderer>().material.color = Color.green;
            // Move the scale down
            scaleThree.transform.position = scaleDownPosition;
            // Play a sound
            scaleThree.GetComponent<AudioSource>().Play();
            scaleThreeCorrect = true;
            Debug.Log(scaleThreeCorrect);
        }
    }
}