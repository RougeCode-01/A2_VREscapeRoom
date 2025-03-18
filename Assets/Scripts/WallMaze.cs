using UnityEngine;

public class WallMaze : MonoBehaviour
{
    [SerializeField] private GameObject puzzlePiece; // Assign the puzzle piece in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            RevealPuzzlePiece();
        }
    }

    private void RevealPuzzlePiece()
    {
        if (puzzlePiece != null)
        {
            puzzlePiece.SetActive(true); // Reveal the puzzle piece
        }
    }
}