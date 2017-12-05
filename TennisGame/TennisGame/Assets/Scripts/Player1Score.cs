using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player1Score : MonoBehaviour
{
    public Text ScorePlayer1;
    public static int Score1;
    public int MaxScore1;
    public string level;
    public int ScoreAddition;
    public string Nextlevel;




    LevelManager levelManager = new LevelManager();
  
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ScorePlayer1.text = Score1.ToString();
        if (Score1 == MaxScore1)
        {
            SceneManager.LoadScene(Nextlevel);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Score1 = Score1 + ScoreAddition;
       
        SceneManager.LoadScene(level);
        
    }
}
