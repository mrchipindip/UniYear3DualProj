using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinished : MonoBehaviour {

    private bool playerWithinTrigger = false;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (playerWithinTrigger == true)
        {
            SceneManager.LoadScene("MainMenu");
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
