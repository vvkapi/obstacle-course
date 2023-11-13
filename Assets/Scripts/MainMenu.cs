using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highScoreText;

    private void Start()
    {
        int highScore = PlayerPrefs.GetInt(Score.HighScore, 0);

        highScoreText.text = "High Score: \n" + highScore.ToString();
    }


    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
