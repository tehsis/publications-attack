using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class PlayerScore : MonoBehaviour {

	private int score;
	public TextMeshProUGUI scoreUI;
	[SerializeField] string levelName;

	[SerializeField] AudioClip coin;

	private AudioSource audiosource;

	// Use this for initialization
	void Start () {
		score = 0;
		PlayerPrefs.SetString("level", levelName);
		PlayerPrefs.SetInt("totalScore", GameObject.FindGameObjectsWithTag("book").Length);
		audiosource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		scoreUI.text = score.ToString();
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "book") {
			other.gameObject.SetActive (false);
			audiosource.PlayOneShot(coin);
			score++;
		}

		if (other.tag == "computer") {
			PlayerPrefs.SetInt("score", score);	
			SceneManager.LoadScene ("Score");
		}
	}
}
