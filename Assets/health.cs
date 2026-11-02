
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public int MaxHealth = 3;
    public int CurrentHealth = 3;
    public Image HealthBarImage;

    private GameOverManager gameOverManager;
    private bool isDead = false;

    void Start()
    {
        gameOverManager = FindFirstObjectByType<GameOverManager>();
        UpdateHealthBar();
    }

    public void UpdateHealthBar()
    {
        HealthBarImage.fillAmount =
            (float)CurrentHealth / MaxHealth;
    }

    public void TakeDamage()
    {
        if (isDead) return;

        CurrentHealth = Mathf.Max(0, CurrentHealth - 1);
        UpdateHealthBar();

        if (CurrentHealth <= 0)
        {
            isDead = true;
            gameOverManager.GameOver();
        }
    }
}
