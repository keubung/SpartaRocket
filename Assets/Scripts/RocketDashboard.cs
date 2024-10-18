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

    private float currentscore = 0f;
    private float highscore = 0f;

    private void Update()
    {
        CurrentScore();
        HighScore();
    }

    public void CurrentScore()
    {
        // TODO : 만약 슛버튼을 눌렀다면
        rocket_y = transform.localPosition;
        currentscore = rocket_y.y;
        currentscore = Mathf.Round(currentscore * 100) / 100;
        CurrentScoreTxt.text = $"{currentscore} M";
    }

    public void HighScore()
    {

        if (highscore < currentscore)
        {
            highscore = currentscore;
        }

        HighScoreTxt.text = $"HIGH : {highscore} M";
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("RocketLauncher");
    }
}
