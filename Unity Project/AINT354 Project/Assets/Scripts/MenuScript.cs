using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {
	public Canvas quitMenu;
	public Button playText;
	public Button quitText;


	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		playText = playText.GetComponent<Button> ();
		quitText = quitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}

	public void ExitPress() {
		quitMenu.enabled = true;
		playText.enabled = false;
		quitText.enabled = false;
	}

	public void NoPress() {
		quitMenu.enabled = false;
		playText.enabled = true;
		quitText.enabled = true;
	}

	public void StartGame() {
		SceneManager.LoadScene ("FirstLevel");
	}

	public void StartTutorial() {
		SceneManager.LoadScene ("Tutorial Child");
	}

	public void ExitGame() {
		Application.Quit ();
	}
	
}
