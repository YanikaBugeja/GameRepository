using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2Score : MonoBehaviour
{
    LevelManager levelManager = new LevelManager();
    public Text ScorePlayer2;
    
    public static int Score2;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        ScorePlayer2.text = Score2.ToString();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Score2 = Score2 + 2;
        if (Score2 <= 2)
        {
            SceneManager.LoadScene("Level_01");
        }
        if (Score2 == 10)
        {

            SceneManager.LoadScene("Level_02");
        }

        if (Score2 == 25)
        {
            SceneManager.LoadScene("Level_03");
        }

        if (Score2 == 35)
        {
            SceneManager.LoadScene("EndScene");
        }
    }

}
