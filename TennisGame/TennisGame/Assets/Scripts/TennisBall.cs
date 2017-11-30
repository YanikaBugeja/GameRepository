using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisBall : MonoBehaviour {
    PaddlePlayer1 paddlePlayer1;
    Vector3 ballPaddleDiff;

    bool gameStarted = false;

    // Use this for initialization
    void Start () {
        paddlePlayer1 = GameObject.FindObjectOfType<PaddlePlayer1>();
        ballPaddleDiff = this.transform.position - paddlePlayer1.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            this.transform.position = paddlePlayer1.transform.position +ballPaddleDiff;
            
        }
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 5f);
        }
    }


}
