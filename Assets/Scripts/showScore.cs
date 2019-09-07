using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showScore : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int score = PlayerPrefs.GetInt("Score");	
	}
}
