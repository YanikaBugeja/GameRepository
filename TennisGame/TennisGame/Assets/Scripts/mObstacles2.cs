using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mObstacles2 : MonoBehaviour {
    float obstacle2PositionInUnits;
   
    bool value;
    // Use this for initialization

    void Start()
    {

        

    }

    // Update is called once per frame
    void Update()
    {
        if (obstacle2PositionInUnits >= 3.5f)
        {
            value = true;
        }
        if (obstacle2PositionInUnits <= -3.5f)
        {
            value = false;
        }



        if (value == true)
        {
            obstacle2PositionInUnits -= 0.05f;
        }
        if (value == false)
        {

            obstacle2PositionInUnits += 0.05f;
        }

        this.GetComponent<Rigidbody2D>().velocity = new Vector3(0f, obstacle2PositionInUnits, 1f);
        print(obstacle2PositionInUnits);




    }
}
