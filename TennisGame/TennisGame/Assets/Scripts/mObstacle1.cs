using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mObstacle1 : MonoBehaviour {
    float obstaclePositionInUnits;
    mObstacle1 Obstacle1;
    bool value;

    // Use this for initialization
    void Start () {
         
    }
	
	// Update is called once per frame
	void Update () {
        if (obstaclePositionInUnits >= 3.5f)
        {
            value = true;
        }
        if (obstaclePositionInUnits <= -3.5f)
        {
            value = false;
        }



        if (value == true)
        {
            obstaclePositionInUnits -= 0.05f;
        }
        if (value == false)
        {

            obstaclePositionInUnits += 0.05f;
        }

        this.GetComponent<Rigidbody2D>().velocity = new Vector3 (0f, obstaclePositionInUnits,1f);
        print(obstaclePositionInUnits);




    }



}

