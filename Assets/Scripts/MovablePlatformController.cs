using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovablePlatformController : MonoBehaviour {
	[SerializeField] Transform destiny;
	[SerializeField] float speed = 2f;

	private Vector3 posA;
	private Vector3 posB;
	private Vector3 nextPos;

	private Transform originalParent;
	
	void Start() {
		posA = transform.localPosition;
		posB = destiny.localPosition;
		nextPos = posB;
	}

	void Update () {
		move();
	}

	void move() {
		transform.localPosition = Vector3.MoveTowards(transform.localPosition, nextPos, speed * Time.deltaTime);

		if (Vector3.Distance(transform.localPosition, nextPos) <= 0.1) {
			changeDestination();
		}
	}

	void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "Player") {
			originalParent = collision.collider.transform.parent;
			collision.collider.transform.SetParent(transform);
		}
	}

	void OnCollisionExit2D(Collision2D collision) {
		if (collision.gameObject.tag == "Player") {
			collision.collider.transform.SetParent(originalParent);
		}
	}

	void changeDestination() {
		nextPos = nextPos != posA ? posA : posB;
	}
}
