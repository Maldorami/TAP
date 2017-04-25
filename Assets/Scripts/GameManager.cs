﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    
    [HideInInspector]
    public static GameManager instance;

    public int PlayerLives;
    public int Score = 0;
    public int Velocity = 30;
    public int HighScore;

    public Text ScoreText;

    public GameObject panel;    
    public Text EndScoreText;
    public Text HighScoreText;

    public bool start = false;
    public GameObject StartImage;

    public Animator anim;

    public GameObject pad;

	void Start () {

        HighScore = PlayerPrefs.GetInt("HighScore", 0);

        if (!instance)
        {
            instance = this;
        }

	}

    public void SumarPuntos()
    {
        Score += 1;
        ActualizarVelocidad();
        ActualizarScoreText();

        if(Score > HighScore){
            HighScore = Score;
        }
    }

    public int ActualizarVelocidad()
    {
        Velocity += Score / 3;

        if (Velocity > 100)
            Velocity = 100;

        return Velocity;
    }

    public void ActualizarScoreText()
    {
        ScoreText.text = Score.ToString();
    }

	void Update () {
        if (start)
        {
            if (PlayerLives <= 0)
            {
                pad.SetActive(false);

                Time.timeScale = 0;

                PlayerPrefs.SetInt("HighScore", HighScore);

                panel.SetActive(true);

                EndScoreText.text = "Score:\n" + Score.ToString();
                HighScoreText.text = "HighScore:\n" + HighScore.ToString();
            }
        }
        else
        {
            Time.timeScale = 0;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                StartGame();
            }
        }
	}

    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        start = true;
        StartImage.SetActive(false);
        Time.timeScale = 1;
    }

    public void CambiarLado()
    {
        if (anim.GetBool("Change"))
        {
            anim.SetBool("Change", false);
            SumarPuntos();
        }

        else
        {
            anim.SetBool("Change", true);
            SumarPuntos();
        }
    }
}
