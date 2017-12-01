using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2Score : MonoBehaviour
{

    public Text ScorePlayer2;

    public static int Score2;
    LevelManager levelManager = new LevelManager();
    // Use this for initialization
    void Start()
    {
        


    }

    // Update is called once per frame
    void Update()
    {
        ScorePlayer2.text = Score2.ToString();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Score2 = Score2 + 2;
        
        if (Score2 >= 0 && Score2 < 6)
        {
            SceneManager.LoadScene("Level_01");
        }
        if (Score2 >= 6 && Score2 < 8)
        {

            SceneManager.LoadScene("Level_02");
        }

        if (Score2 >= 8 && Score2 < 10)
        {
            SceneManager.LoadScene("Level_03");
        }

        if (Score2 >= 10 && Score2 < 12)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}


