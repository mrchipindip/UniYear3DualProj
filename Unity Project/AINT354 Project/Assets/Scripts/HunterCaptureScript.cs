using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HunterCaptureScript : MonoBehaviour {

    private float captureAmount = 100.0f;
    private bool playerWithinTrigger = false;
    public Slider healthSlider;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (playerWithinTrigger == true)
        {
            captureAmount -= (Time.deltaTime * 10);
            Debug.Log(captureAmount);
            healthSlider.value = (captureAmount - 0) * (1 - 0) / (100 - 0) + 0;
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
