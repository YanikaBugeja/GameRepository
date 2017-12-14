using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player1Scores : MonoBehaviour {
    public Text ScorePlayer1;
    public static int Score1;
    int Score2;
    public static int StoreScore1;
   
    public int MaxScore;
    public string level;
    public int ScoreAddition;
    public string Nextlevel;

    
    // Use this for initialization
    void Start () {
        Score2 = Player2Scores.Score2;
        
    }
	
	// Update is called once per frame
	void Update () {
        ScorePlayer1.text = Score1.ToString();

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        print("Collision");
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        Score1 = Score1 + ScoreAddition;
        StoreScore1 += Score1;
        SceneManager.LoadScene(level);
        StartValue();
    }
  
    public void StartValue()
    {
        if (Score1 == MaxScore )
        {
            SceneManager.LoadScene(Nextlevel);
            Score1 = 0;
            Player2Scores.Score2 = 0;
        }
    }

}