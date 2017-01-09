using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour {
	GameObject[] musicObject;
	
	// Use this for initialization
	void Start () {								//For the music i have in my game i wanted it to carry on playing no matter which scene you were on with no interuptions
		musicObject = GameObject.FindGameObjectsWithTag ("GameMusic");
		if (musicObject.Length == 1 ) {				//if the music isnt playing, or at the end of he loop, play it again.
			GetComponent<AudioSource>().Play ();
		} else {
			for(int i = 1; i < musicObject.Length; i++){			//destroys all instances of the GameMusic music
				Destroy(musicObject[i]);
			}
			
		}
		
		
	}
	

	void Awake(){
		DontDestroyOnLoad (this.gameObject);				//stops unity from destroying the object if the scene changes.
	}




}
