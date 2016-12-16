using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOnImpact : MonoBehaviour {

    private AudioSource soundToPlay;

	// Use this for initialization
	void Start () {
        soundToPlay = gameObject.GetComponent<AudioSource>();
    }
	

	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Floor")
        {
            soundToPlay.Play();
        }
        
    }
}
