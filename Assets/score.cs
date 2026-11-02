using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;
    public TextMeshProUGUI ScoreText;

    void Start()
    {
        UpdateScore();
    }

    public void AddPoint()
    {
        Score++;
        UpdateScore();
    }

    void UpdateScore()
    {
        ScoreText.text = "Score: " + Score;
    }

}