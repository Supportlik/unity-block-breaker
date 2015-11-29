using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name){
		Debug.Log("Trying to load: " + name);
		Application.LoadLevel(name);	
	}	
	
	public void Quit(){
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
