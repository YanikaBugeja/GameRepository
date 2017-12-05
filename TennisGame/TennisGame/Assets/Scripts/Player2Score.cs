using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2Score : MonoBehaviour
{
    public Text ScorePlayer2;
    public static int Score2;
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
        ScorePlayer2.text = Score2.ToString();
        if (Score2 == MaxScore1)
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
        Score2 = Score2 + ScoreAddition;

        SceneManager.LoadScene(level);

    }

}


