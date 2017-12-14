using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2Scores : MonoBehaviour
{
    public Text ScorePlayer2;
    public static int Score2;
    int Score1;
    public static int StoreScore2;
  
    public int MaxScore;
    public string level;
    public int ScoreAddition;
    public string Nextlevel;

    LevelManager levelManager = new LevelManager();
    // Use this for initialization
    void Start()
    {
        Score1 = Player1Scores.Score1;
        
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
        Score2 = Score2 + ScoreAddition;
        StoreScore2 += Score2;
        SceneManager.LoadScene(level);
        StartValue();
    }
   
    public void StartValue()
    {
        if (Score2 == MaxScore )
        {
            SceneManager.LoadScene(Nextlevel);
            Score2 = 0;
            Player1Scores.Score1 = 0;
        }
    }

}

