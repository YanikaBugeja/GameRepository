using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class WinnerScript : MonoBehaviour {

    // Use this for initialization


    public Text Winner;
    public Text Score1;
    public Text Score2;
    int StoreScore1;
    int StoreScore2;
    

    // Use this for initialization
    void Start()
    {
        StoreScore1 = Player1Scores.StoreScore1;
        StoreScore2 = Player2Scores.StoreScore2;
        Score1.text = StoreScore1.ToString();
        Score2.text = StoreScore2.ToString();
        WinnerDisplay();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WinnerDisplay()
    {
        if (StoreScore1 > StoreScore2)
        {
            Winner.text = "Player 1 : You Won !! ";
        }
        else if (StoreScore1 < StoreScore2)
        {
            Winner.text = "Player 2 : You Won !! ";

        } else if (StoreScore1 == StoreScore2)
        {
            Winner.text = "Player 1 AND Player 2 Won ";
        }
    }
}