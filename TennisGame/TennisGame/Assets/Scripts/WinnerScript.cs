using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WinnerScript : MonoBehaviour {

	// Use this for initialization
	

    public Text Winner;
    public Text ScorePlayer1;
    public static int Score1;
    public Text ScorePlayer2;
    public static int Score2;

    // Use this for initialization
    void Start()
    {
       
        Score1 = Player1Score.Score1;
        Score2 = Player2Score.Score2;
        WinnerDisplay();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void WinnerDisplay()
    {
        if (Score1 > Score2)
        {
            Winner.text = "Player 1 : You Won !! ";
        }
        else if (Score1 < Score2)
        {
            Winner.text = "Player 2 : You Won !! ";


        }
    }
}