using UnityEngine;

public class PointBlock : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Something touched the yellow block!");

        if (other.CompareTag("Player"))
        {
            Debug.Log("The player touched the yellow block!");

            ScoreManager scoreManager = FindFirstObjectByType<ScoreManager>();

            if (scoreManager != null)
            {
                scoreManager.AddPoint();
                Debug.Log("Point added!");
            }
            else
            {
                Debug.LogError("ScoreManager not found!");
            }
        }
    }
}