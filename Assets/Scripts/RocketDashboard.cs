using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RocketDashboard : Rocket
{
    [SerializeField] private TextMeshProUGUI CurrentScoreTxt;
    [SerializeField] private TextMeshProUGUI HighScoreTxt;
    [SerializeField] private Button ReButton;

    private float currentScore = 0f;
    private float highScore = 0f;
    private const string HighScoreKey = "HighScore";

    private void Update()
    {
        CurrentScore();
        UpdateHighScore();
    }

    private void Start()
    {
        LoadHighScore();
    }

    public void CurrentScore()
    {
        // TODO : 만약 슛버튼을 눌렀다면
        rocket_y = transform.localPosition;
        currentScore = rocket_y.y;
        currentScore = Mathf.Round(currentScore * 100) / 100;
        CurrentScoreTxt.text = $"{currentScore} M";
    }

    public void UpdateHighScore()
    {

        if (highScore < currentScore)
        {
            highScore = currentScore;
            SaveHighScore();
        }

        HighScoreTxt.text = $"HIGH : {highScore} M";
    }

    public void SaveHighScore()
    {
        PlayerPrefs.SetFloat(HighScoreKey, highScore);
        PlayerPrefs.Save();
    }

    private void LoadHighScore()
    {
        if (PlayerPrefs.HasKey(HighScoreKey))
        {
            highScore = PlayerPrefs.GetFloat(HighScoreKey);
        }
    }

    public float GetHighScore()
    {
        return highScore;
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("RocketLauncher");
    }
}
