using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;
	
	void OnTriggerEnter2D(Collider2D collider){
		Debug.Log("Lose Trigger");
		levelManager.LoadLevel("Lose");
	}
}
