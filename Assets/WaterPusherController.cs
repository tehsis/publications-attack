using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPusherController : MonoBehaviour {

	[SerializeField] float forcePower = 5.0f;

	void OnTriggerEnter2D(Collider2D other) {
		Rigidbody2D rb = other.GetComponent<Rigidbody2D>();

		if (rb != null) {
			rb.velocity = Vector3.up * forcePower;
		}
	}
}
