using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeatTriggerController : MonoBehaviour {

	[SerializeField] CharacterMovement character;

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			character.OnDead();
			StartCoroutine(ChangeScreenAfterSeconds(SceneManager.GetActiveScene().name, 1f));
		}
	}

	IEnumerator ChangeScreenAfterSeconds(string name, float time) {
		yield return new WaitForSeconds(time);
		SceneManager.LoadScene(name);
	}

	
}
