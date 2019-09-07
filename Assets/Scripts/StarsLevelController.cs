using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarsLevelController : MonoBehaviour {

	[SerializeField] string level;
	[SerializeField] Image star1;
	[SerializeField] Image star2; 

	[SerializeField] Image star3;

	private bool star1Enabled = false;
	private bool star2Enabled = false;
	private bool star3Enabled = false;

	void Start() {
		star1Enabled = PlayerPrefs.GetInt(level + "star1") == 1;
		star2Enabled = PlayerPrefs.GetInt(level + "star2") == 1;
		star3Enabled = PlayerPrefs.GetInt(level + "star3") == 1;

		Color c3 = star1.color;
		c3.a = star3Enabled ? 255 : 0;
		star3.color = c3;

		Color c2 = star1.color;
		c2.a = star2Enabled ? 255 : 0;
		star2.color = c2;

		Color c1 = star1.color;
		c1.a = star1Enabled ? 255 : 0;
		star1.color = c1;
	}

}
