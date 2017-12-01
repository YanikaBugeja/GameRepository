using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddlePlayer2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        // Player2 Paddle Using The Mouse
       
        float mousePositionInUnits = ((Input.mousePosition.y / Screen.width) * 16) - 8;
        Vector3 newPaddlePosition = new Vector3(gameObject.transform.position.x, mousePositionInUnits, 
                                                gameObject.transform.position.z);
        newPaddlePosition.y = Mathf.Clamp(mousePositionInUnits, -3f, 3f);

        this.transform.position = newPaddlePosition;
    }
}
	
