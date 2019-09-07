using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectorController : MonoBehaviour {

	void Update() {
		if (Input.GetKey(KeyCode.Escape)) {
			goToMenu();
		}
	}

	public void goToMenu() {
		SceneManager.LoadScene("Menu");
	}

	public void goToDessertLevel() {
		SceneManager.LoadScene("Dessert");
	}

	public void goToSnowLevel() {
		SceneManager.LoadScene("Snow");
	}
	public void goToForestLevel() {
		SceneManager.LoadScene("Forest");
	}
}
