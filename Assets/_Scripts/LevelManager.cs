using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	
	public void LoadLevel(string name){
		Debug.Log("Trying to load: " + name);
		if(name == "Level_01"){
			Screen.showCursor = false;
		} else {
			Screen.showCursor = true;
		}
		Application.LoadLevel(name);	
	}	
	
	public void Quit(){
		Debug.Log("QUIT!");
		Application.Quit();
	}
}
