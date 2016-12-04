using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class WaitTimeThenLoadLevel : MonoBehaviour {
	public float timer = 2f;
	public string levelToLoad = "Level1";


	// Use this for initialization
	void Start () {
		StartCoroutine ("DisplayScene");
	}
	
	IEnumerator DisplayScene() {
		yield return new WaitForSeconds (timer);
		SceneManager.LoadScene(levelToLoad);
	}
}
