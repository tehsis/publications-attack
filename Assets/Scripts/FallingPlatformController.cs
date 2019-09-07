using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatformController : MonoBehaviour {

	[SerializeField] float afterTime = 0.5f;

	void OnCollisionEnter2D(Collision2D collider) {
		StartCoroutine(fallPlatform());
	}

	IEnumerator fallPlatform() {
		yield return new WaitForSeconds(afterTime);
		gameObject.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
	}
}
