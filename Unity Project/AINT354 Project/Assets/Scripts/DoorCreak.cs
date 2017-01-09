using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorCreak : MonoBehaviour {

    private AudioSource creakingSound;

	// Use this for initialization
	void Start () {
        creakingSound = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "childPlayer" || col.gameObject.tag == "hunterPlayer")
        {
            if (Random.Range(0.0f, 6.0f) > 4.0f)
            {
                creakingSound.Play();
            }
        }
    }

}
