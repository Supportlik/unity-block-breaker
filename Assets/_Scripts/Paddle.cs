using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	
	float left_corner;
	float right_corner;
	float full_width;	
	float mousePosInBlocks;
	
	
	// Use this for initialization
	void Start () {
		left_corner = -10.19f;
		right_corner = 10.19f;
		full_width = right_corner * 2;
		mousePosInBlocks = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, this.transform.position.y);
		mousePosInBlocks = Input.mousePosition.x / Screen.width;		
		mousePosInBlocks = left_corner + full_width * mousePosInBlocks;		
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, left_corner, right_corner);
		this.transform.position = paddlePos;
	}
}
