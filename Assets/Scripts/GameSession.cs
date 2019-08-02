using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameSession : MonoBehaviour
{
    // Configurable Parameters
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] float gameSpeed = 1f;

    // State Variables
    private int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameSpeed < 2.0f)
        {
            gameSpeed = currentScore / 30 * 0.1f + 1;
        }
        Time.timeScale = gameSpeed;
    }

    public void AddToScore()
    {
        currentScore += 1;
        scoreText.text = currentScore.ToString();
    }
}
