using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreScreenController : MonoBehaviour {

	[SerializeField] Sprite dessertBackground;
	[SerializeField] Sprite snowBackground;
	[SerializeField] Sprite forestBackground;


	void Awake() {
		string level = PlayerPrefs.GetString("level");
		Image img = gameObject.GetComponent<Image>();

		if (level == "snow") {
			img.sprite = snowBackground;
		}

		if (level == "dessert") {
			img.sprite = dessertBackground;
		}

		if (level == "forest") {
			img.sprite = forestBackground;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.Escape)) {
			SceneManager.LoadScene("LevelSelector");
		}
	}
}
