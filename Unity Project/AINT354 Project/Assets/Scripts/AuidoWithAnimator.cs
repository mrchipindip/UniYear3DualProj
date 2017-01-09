using UnityEngine;
using System.Collections;

public class AuidoWithAnimator : MonoBehaviour {

	public float soundToPlay = -1.0f;
	public AudioClip[] audioClip;

	AudioSource audio;


	// Use this for initialization
	void Start () {
		audio = GetComponent <AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	if (soundToPlay > -1.0f) {
			soundToPlay = -1.0f;
		}
	}

	void PlaySound (int clip, float volumeScale) {
		audio.PlayOneShot (audioClip [clip], volumeScale);
	}
	}

