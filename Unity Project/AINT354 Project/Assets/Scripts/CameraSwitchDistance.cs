using UnityEngine;
using System.Collections;

public class CameraSwitchDistance : MonoBehaviour {
	public Camera childCam;
	public Camera hunterCam;

	public Transform child;
	public Transform Hunter;

	private float distance = 0;
	private float timeToWait = 0;

	public bool looping = true;

	public void Start() {
		childCam.enabled = true;
		hunterCam.enabled = false;
		StartCoroutine (LoopingWaitTime());
	}


	IEnumerator LoopingWaitTime(){
		while (looping) {
			CalculateDistance ();
			timeToWait = distance / 1.2f;
			Debug.Log ("Calling IEnumerator");
			Debug.Log (distance);
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

}
