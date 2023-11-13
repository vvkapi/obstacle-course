using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float multiplier;
    private float score;
    public const string HighScore = "HighScore";

    void Update()
    {
        score += Time.deltaTime * multiplier;

        scoreText.text = Mathf.FloorToInt(score).ToString();
    }

    private void OnDestroy()
    {
        int currentHighScore = PlayerPrefs.GetInt(HighScore, 0);

        if (score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighScore, Mathf.FloorToInt(score));
        }
    }
}
