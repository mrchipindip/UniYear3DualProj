using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDoorUnlock : MonoBehaviour {

    public AudioSource soundToPlay;
    public AudioSource soundToPlay2;
    private Rigidbody rb;
    private bool doorUnlockable = false;
    private bool playerWithinTrigger = false;
    private bool doorAlreadyUnlocked = false;
    // Use this for initialization
    void Start () {
        soundToPlay = gameObject.GetComponent<AudioSource>();
        rb = gameObject.GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerWithinTrigger == true && doorAlreadyUnlocked == false && doorUnlockable == true)
        {
            rb.isKinematic = false;
            doorAlreadyUnlocked = true;
            soundToPlay.Play();
        }

        if (Input.GetKeyDown(KeyCode.E) && playerWithinTrigger == true && doorAlreadyUnlocked == false && doorUnlockable == false)
        {
            soundToPlay2.Play();
        }
    }

    void UnlockDoor()
    {
        doorUnlockable = true;
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
