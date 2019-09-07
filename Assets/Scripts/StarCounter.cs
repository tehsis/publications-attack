using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarCounter : MonoBehaviour {

	
	[SerializeField] RawImage FirstStar;

	[SerializeField] ParticleSystem FirstStarParticles;
	[SerializeField] RawImage SecondStar;
	[SerializeField] ParticleSystem SecondStarParticles;

	[SerializeField] RawImage ThirdStar;
	[SerializeField] ParticleSystem ThirdStarParticles;

	private string level;

	void Start() {
		FirstStar.enabled = false;
		SecondStar.enabled = false;
		ThirdStar.enabled = false;

		level = PlayerPrefs.GetString("level");
	}
	// Update is called once per frame
	public void showFirstStar() {
		FirstStar.enabled = true;
		PlayerPrefs.SetInt(level + "star1", 1);
		FirstStarParticles.Play();
	}

	public void showSecondStar() {
		SecondStar.enabled = true;
		PlayerPrefs.SetInt(level + "star2", 1);
		FirstStarParticles.Stop();
		SecondStarParticles.Play();

	}

	public void showThirdStar() {
		ThirdStar.enabled = true;
		PlayerPrefs.SetInt(level + "star3", 1);
		FirstStarParticles.Stop();
		SecondStarParticles.Stop();
		ThirdStarParticles.Play();
	}
}
