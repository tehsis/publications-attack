using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slipperyGroundController : MonoBehaviour {
	private Vector3 m_Velocity = Vector3.zero;
	[Range(0, .3f)] [SerializeField] private float m_MovementSmoothing = .05f;

	private GameObject moving = null;

	void Update() {
		if (moving != null) {
			Rigidbody2D otherRb = moving.GetComponent<Rigidbody2D>();

			Vector3 targetVelocity = new Vector2(-1 * 5f,0);
			// And then smoothing it out and applying it to the character
			otherRb.velocity = Vector3.SmoothDamp(otherRb.velocity, targetVelocity, ref m_Velocity, m_MovementSmoothing);
		}
	}
	
	void OnCollisionEnter2D (Collision2D other) {
		moving = other.gameObject;
	}

	void OnCollisionExit2D (Collision2D other) {
		moving =  null;
	}
}
