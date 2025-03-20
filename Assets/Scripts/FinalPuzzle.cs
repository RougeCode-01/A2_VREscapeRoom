using System;
using UnityEngine;

public class FinalPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject scaleOne;
    [SerializeField] private GameObject scaleTwo;
    [SerializeField] private GameObject scaleThree;
    [SerializeField] private GameObject doorToOpen;
    
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
        // Open the door by enabling the xr intractable component
        //Animate the door to open
        //Play a sound
    }

    private void OnCollisionEnter(Collision other)
    {
        // Check if the object that collided with the scale is the puzzle piece
        if (other.gameObject.CompareTag("PuzzlePieceOne"))
        {
            //Change color of scaleOne
            //Animate the scale to move down if it right or up if it is wrong
            //Play a sound
            scaleOneCorrect = true;
            Debug.Log(scaleOneCorrect);
        }
        else if (other.gameObject.CompareTag("PuzzlePieceTwo"))
        {
            //Change color of scaleTwo
            //Animate the scale to move down if it right or up if it is wrong
            //Play a sound
            scaleTwoCorrect = true;
            Debug.Log(scaleTwoCorrect);
        }
        else if (other.gameObject.CompareTag("PuzzlePieceThree"))
        {
            //Change color of scaleThree
            //Animate the scale to move down if it right or up if it is wrong
            //Play a sound
            scaleThreeCorrect = true;
            Debug.Log(scaleThreeCorrect);
        }
    }
    
}
