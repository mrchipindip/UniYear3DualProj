using UnityEngine;
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

	private float distance = 0;
	private float timeToWait = 0;

	public float dividerMultiplier = 1.2f;

	public bool looping = true;
	private bool finalChanceSwitchOccured = false;

	public void Start() {
		childCam.enabled = true;
		hunterCam.enabled = false;
		StartCoroutine (LoopingWaitTime());
	}

	public void Update(){
		CalculateDistance ();

		if (distance < 2 && !finalChanceSwitchOccured && childCam.enabled == false) {
			finalChanceSwitchOccured = true;
			SwitchCameras ();
		}

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
			if (hunterCam.enabled) {
				timeToWait = (distance / dividerMultiplier);
                timeCheck = false;
			} else if(childCam.enabled) {
				timeToWait = (distance / dividerMultiplier) + 2;
                timeCheck = false;
            }
			Debug.Log (timeToWait);
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
