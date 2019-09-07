using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextScrollController : MonoBehaviour {

	[SerializeField] float speed = 2.0f;
	[SerializeField] Transform destiny;

	void Update () {
		transform.localPosition = transform.localPosition + new Vector3(0, speed, 0);
		if (Vector3.Distance(transform.localPosition, destiny.localPosition) < 5 || Input.GetKeyDown(KeyCode.Return)) {
			StartCoroutine(transitiontoScene("LevelSelector", 1));
		}
	}

	IEnumerator transitiontoScene(string name, float afterSeconds) {
		yield return new WaitForSeconds(afterSeconds);
		SceneManager.LoadScene(name);
	}
}
