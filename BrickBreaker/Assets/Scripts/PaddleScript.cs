using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour {
    public bool autoPlay;
    private GameObject BallScript;

    
	// Use this for initialization
	void Start () {
        BallScript = FindObjectOfType<BallScript>().gameObject;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlePosition = new Vector3(0, gameObject.transform.position.y, 0);

        if (autoPlay == true)
        {
            paddlePosition.x = BallScript.transform.position.x;
        }
        else
        {

            float mousePositionInBlocks = Mathf.Clamp( Input.mousePosition.x / Screen.width * 20- 20f, - 20f, 20f );

            paddlePosition.x = mousePositionInBlocks;
        }
        gameObject.transform.position = paddlePosition;

	}
}
