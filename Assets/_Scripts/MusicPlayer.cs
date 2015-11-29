using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	
	public static MusicPlayer instance = null;
	
	// Use this for initialization
	void Start () {
		if(instance == null){
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		} else {
			Destroy (gameObject);
			Debug.Log("Destroy duplicate music player!");
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
