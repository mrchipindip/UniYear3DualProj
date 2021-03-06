﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour {

    private AudioSource soundToPlay;
    private bool playerWithinTrigger = false;
    private MeshRenderer keyMesh;
    public GameObject exitDoor;
	// Use this for initialization
	void Start () {
        soundToPlay = gameObject.GetComponent<AudioSource>();
        keyMesh = gameObject.GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.E) && playerWithinTrigger == true)
        {
            exitDoor.SendMessage("UnlockDoor");
            soundToPlay.Play();
            keyMesh.enabled = false;
        }
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "childPlayer")
        {
            playerWithinTrigger = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "childPlayer")
        {
            playerWithinTrigger = false;
        }
    }
}
