﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player1Score : MonoBehaviour
{

    public Text ScorePlayer1;

    public static int Score1;
    LevelManager levelManager = new LevelManager();
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        ScorePlayer1.text = Score1.ToString();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Score1 = Score1 + 2;
        if (Score1 <= 2)
        {
            SceneManager.LoadScene("Level_01");
        }
        if (Score1 == 10)
        {

            SceneManager.LoadScene("Level_02");
        }

        if (Score1 == 25)
        {
            SceneManager.LoadScene("Level_03");
        }

        if (Score1 == 35)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
