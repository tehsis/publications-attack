using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using TMPro;

public class Counter : MonoBehaviour {

	public UnityEvent onFirstThird;
	public UnityEvent onSecondThird;
	public UnityEvent onThirdThird;

	int playerScore;
	int totalScore;
	[SerializeField] float speed = 1;
	[SerializeField] AudioClip countAudio;

	private int currentScore = 0;

	private TextMeshProUGUI scoreText;

	private AudioSource audioSource;

	private int firstThird;
	private int secondThird;
	private int thirdThird;

	void Start() {
		playerScore = PlayerPrefs.GetInt("score");
		totalScore  = PlayerPrefs.GetInt("totalScore");

		firstThird = totalScore / 3;
		secondThird = firstThird * 2;
		thirdThird = firstThird * 3;
	}
	void Awake() {
		scoreText = GetComponent<TextMeshProUGUI>();
		audioSource = GetComponent<AudioSource>();
	}

	private float lastUpdate;
	
	// Update is called once per frame
	void Update () {
		float timeSinceLastUpdate = Time.fixedTime - lastUpdate; 
		if (timeSinceLastUpdate > speed) {
			if (currentScore < playerScore) {
				currentScore += 1;
				lastUpdate = Time.fixedTime;
				audioSource.PlayOneShot(countAudio);
			}

			if (currentScore == firstThird) {
				onFirstThird.Invoke();
			}

			if (currentScore == secondThird) {
				onSecondThird.Invoke();
			}

			if (currentScore == thirdThird) {
				onThirdThird.Invoke();
			}
		}
	}

	void FixedUpdate() {
		scoreText.text = currentScore.ToString();
	}
}
