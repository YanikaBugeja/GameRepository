using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacles : MonoBehaviour {
     float mObstacle1;
     bool gameStarted = false;
    // Use this for initialization
    void Start () {

        mObstacle1 = 0.00f;

    }

    // Update is called once per frame
    void Update()
    {
        while (gameStarted)
        {
            if (mObstacle1 <= 3f)
            {
                mObstacle1 += 0.5f;
            }

            else if (mObstacle1 >= -3f)
            {
                mObstacle1 -= 0.5f;
            }
            Vector3 newMovingObjectPosition = new Vector3(gameObject.transform.position.x, mObstacle1,
                                                   gameObject.transform.position.z);
            newMovingObjectPosition.y = Mathf.Clamp(mObstacle1, -3f, 3f);
            this.transform.position = newMovingObjectPosition;
        }
        

        

        
    }
}
