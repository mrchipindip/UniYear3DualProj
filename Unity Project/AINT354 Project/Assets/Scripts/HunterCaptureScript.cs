using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HunterCaptureScript : MonoBehaviour {

    private float captureAmount = 100.0f;
    private bool playerWithinTrigger = false;
    public Slider healthSlider;
	private float damage = 20.0f;
	private bool readyCheck = true;
	public Camera hunterCam;

    // Use this for initialization
    void Start () {
		
	}

	// Update is called once per frame
	void Update () {

		if (playerWithinTrigger == true  && Input.GetKeyDown (KeyCode.RightControl))
        {
			if (readyCheck == true && hunterCam.enabled == true) {
				captureAmount -= damage;
				Debug.Log (captureAmount);
				healthSlider.value = (captureAmount - 0) * (1 - 0) / (100 - 0) + 0;
				readyCheck = false;
				StartCoroutine (LoopingWaitTime());
			}



			if (captureAmount <= 0) {
				SceneManager.LoadScene("MainMenu");
			}
        }
	}

	IEnumerator LoopingWaitTime(){
		yield return new WaitForSeconds (0.5f);
		readyCheck = true;
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
