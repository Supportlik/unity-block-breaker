using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {
	
	public static MusicPlayer instance = null;
	
	void Awake(){
		Debug.Log ("Music player Awake " + GetInstanceID());
		if(instance == null){
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		} else {
			Destroy (gameObject);
			Debug.Log("Destroy duplicate music player!");
		}
	}
	
	// Use this for initialization
	void Start () {
		Debug.Log ("Music player Start " + GetInstanceID());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
