using UnityEngine;

public class RoomPuzzle : MonoBehaviour
{
    [SerializeField] private GameObject[] objectsToPlace; // Assign the objects in the Inspector
    [SerializeField] private Transform[] targetPositions; // Assign the target positions in the Inspector
    [SerializeField] private GameObject puzzlePiece; // Assign the puzzle piece in the Inspector
    [SerializeField] private float distanceThreshold = 1f;

    void Update()
    {
        if (AreObjectsCorrectlyPlaced())
        {
            RevealPuzzlePiece();
        }
    }

    private bool AreObjectsCorrectlyPlaced()
    {
        for (int i = 0; i < objectsToPlace.Length; i++)
        {
            if (Vector3.Distance(objectsToPlace[i].transform.position, targetPositions[i].position) > distanceThreshold)
            {
                return false;
            }
        }
        return true;
    }

    private void RevealPuzzlePiece()
    {
        puzzlePiece.SetActive(true); // Reveal the puzzle piece
    }
}