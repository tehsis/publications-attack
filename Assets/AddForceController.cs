using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		Rigidbody2D body = other.gameObject.GetComponent<Rigidbody2D>();
		body.AddForce(new Vector2(1, 100));
	}
}
