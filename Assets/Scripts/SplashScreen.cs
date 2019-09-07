using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {
	[SerializeField] Image splashImage;
	[SerializeField] string nextScene;

	// Use this for initialization
	IEnumerator Start () {
		splashImage.canvasRenderer.SetAlpha (0.0f);

		fadeIn ();

		yield return new WaitForSeconds (2.5f);
		fadeOut ();
		yield return new WaitForSeconds (1.5f);
		SceneManager.LoadScene (nextScene); 

	}
	
	void fadeIn() {
		splashImage.CrossFadeAlpha (1.0f, 1.5f, false);
	}

	void fadeOut() {
		splashImage.CrossFadeAlpha (0.0f, 1.5f, false);
	}
}
