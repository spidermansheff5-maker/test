
using UnityEngine;

public class damage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.GetComponent<PlayerController>();

        if (player != null)
        {
            HealthBar health = FindFirstObjectByType<HealthBar>();

            if (health != null)
            {
                health.TakeDamage();
            }
        }
    }
}
