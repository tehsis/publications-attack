using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

	[SerializeField] CharacterController2D controller;
	[SerializeField] float SpeedMovement = 40f;

	[SerializeField] AudioClip jumpSound;
	[SerializeField] AudioClip deathSound;

	private AudioSource sound;

	private Animator animator;

	private float moveHorizontal = 0f;
	private bool jump = false;
	private bool shouldShout = true;

	void Awake() {
		sound = GetComponent<AudioSource>();
		animator = GetComponent<Animator>();
	}
	
	void Update () {
		moveHorizontal = Input.GetAxisRaw("Horizontal") * SpeedMovement;

		if (Input.GetButtonDown("Jump")) {
			jump = true;
			if (shouldShout) {
				sound.PlayOneShot(jumpSound);
				shouldShout = false;
			}
			animator.SetBool("Jump", true);
		}
		animator.SetFloat("Speed", Mathf.Abs(moveHorizontal));

	}

	public void OnDead() {
		sound.PlayOneShot(deathSound);
	}

	public void OnLanded() {
		animator.SetBool("Jump", false);
		shouldShout = true;
	}

	void FixedUpdate() {
		controller.Move(moveHorizontal * Time.fixedDeltaTime, false, jump);
		jump = false;
	}	
}
