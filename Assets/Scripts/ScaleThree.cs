using UnityEngine;

public class ScaleThree : MonoBehaviour
{
    [SerializeField] private Vector3 scaleDownPosition = new Vector3(0, -1, 0);

    public static bool scaleThreeCorrect = false;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PuzzlePieceThree") && scaleThreeCorrect == false)
        {
            // Move the scale down
            transform.position += scaleDownPosition;
            // Play a sound
            GetComponent<AudioSource>().Play();
            scaleThreeCorrect = true;
            Debug.Log(scaleThreeCorrect);
        }
    }
}