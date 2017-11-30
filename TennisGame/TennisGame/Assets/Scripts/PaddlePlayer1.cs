using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePlayer1 : MonoBehaviour {
    float paddlePositionInUnits;
    // Use this for initialization
    void Start () {
         paddlePositionInUnits = 0.00f;
    }
	
	// Update is called once per frame
	void Update () {
        
        if (Input.GetKey(KeyCode.UpArrow))     
        {
            if (paddlePositionInUnits <= 3f)
            {
                paddlePositionInUnits += 0.40f;
            }
          
               
           
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (paddlePositionInUnits >= -3f)
            {
                paddlePositionInUnits -= 0.40f;
            }

        }
        
        Vector3 newPaddlePosition = new Vector3(gameObject.transform.position.x, paddlePositionInUnits,
                                                    gameObject.transform.position.z);
        newPaddlePosition.y = Mathf.Clamp(paddlePositionInUnits, -3f, 3f);
        this.transform.position = newPaddlePosition;

    }
}
