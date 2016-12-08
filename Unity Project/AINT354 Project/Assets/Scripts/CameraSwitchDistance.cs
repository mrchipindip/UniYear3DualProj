﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CameraSwitchDistance : MonoBehaviour {
	public Camera childCam;
	public Camera hunterCam;

	public Transform child;
	public Transform Hunter;

    public Slider timeRemainingSlider;
    private float timeRemaining;
    private bool timeCheck = false;

	private float distance;
	private float timeToWait = 5;

	public float dividerMultiplier = 1.2f;

	public bool looping = true;
	private bool finalChanceSwitchOccured = false;

	public void Start() {
		childCam.enabled = true;
		hunterCam.enabled = false;
		StartCoroutine (LoopingWaitTime());
	}

	public void Update(){

        if (timeCheck == false)
        {
            timeRemaining = timeToWait;
            timeCheck = true;
        }
        timeRemainingSlider.value = (timeRemaining - 0) * (1 - 0) / (timeToWait - 0) + 0;
        timeRemaining -= Time.deltaTime;
    }


	IEnumerator LoopingWaitTime(){
		while (looping) {
			CalculateDistance ();
			timeToWait = (distance / dividerMultiplier);
			if (timeToWait <= 3 && timeToWait > 1) {
				timeToWait = 3;
			} else if (timeToWait > 3 && timeToWait <= 5) {
				timeToWait = 4;
			} else if (timeToWait <= 1) {
				timeToWait = 1;
			} else { 
				timeToWait = 5;
			}
			if (hunterCam.enabled) {
                timeCheck = false;
                CalculateDistance();
                Debug.Log(timeToWait);
            } else if(childCam.enabled) {
                timeCheck = false;
                Debug.Log(timeToWait);
            }
			yield return new WaitForSeconds (timeToWait);
			SwitchCameras ();
		}
	}

	public void SwitchCameras() {
		if (childCam.enabled) {
			childCam.enabled = false;
			hunterCam.enabled = true;
		} else if (hunterCam.enabled) {
			hunterCam.enabled = false;
			childCam.enabled = true;
		}
	}

	public void CalculateDistance(){
		distance = Vector3.Distance (child.position, Hunter.position);
	}

    private void UpdateTimeBar()
    {
        
    }
}
