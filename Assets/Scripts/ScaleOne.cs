using UnityEngine;

public class ScaleOne : MonoBehaviour
{
    [SerializeField] private Vector3 scaleDownPosition = new Vector3(0, -1, 0);

    public static bool scaleOneCorrect = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PuzzlePieceOne") && scaleOneCorrect == false)
        {
            // Move the scale down
            transform.position += scaleDownPosition;
            // Play a sound
            GetComponent<AudioSource>().Play();
            scaleOneCorrect = true;
            Debug.Log(scaleOneCorrect);
        }
    }
}