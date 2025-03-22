using System;
using UnityEngine;

public class ScaleTwo : MonoBehaviour
{
    [SerializeField] private Vector3 scaleDownPosition = new Vector3(0, -1, 0);

    public static bool scaleTwoCorrect = false;
    
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PuzzlePieceTwo") && scaleTwoCorrect == false)
        {
            // Move the scale down
            transform.position += scaleDownPosition;
            // Play a sound
            GetComponent<AudioSource>().Play();
            scaleTwoCorrect = true;
            Debug.Log(scaleTwoCorrect);
        }
    }
}