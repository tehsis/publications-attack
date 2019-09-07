using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundController : MonoBehaviour {
	Transform cameraTransform;
	Transform[] layers;
	private int leftIndex;
	private int rightIndex;

	float lastCameraX;

	[SerializeField] float backgroundSize = 12.7f;
	[SerializeField] float parallaxSpeed = -3;


	void Start() {
		cameraTransform = Camera.main.transform;
		lastCameraX = cameraTransform.position.x; 
		layers = new Transform[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			layers[i] = transform.GetChild(i);
		}

		leftIndex = 0;
		rightIndex = layers.Length -1;	
	}

	void Update() {
		float deltaX = cameraTransform.position.x - lastCameraX;
		transform.position += Vector3.right * (deltaX * parallaxSpeed);
		lastCameraX = cameraTransform.position.x; 

		if (cameraTransform.position.x < (layers[leftIndex].transform.position.x)) {
			ScrollLeft();
		}

		if (cameraTransform.position.x > (layers[rightIndex].transform.position.x)) {
			ScrollRight();
		}
	}

	private void ScrollLeft() {
		int lastRight = rightIndex;
		layers[rightIndex].position = new Vector3(layers[leftIndex].position.x - backgroundSize, layers[leftIndex].position.y, layers[leftIndex].position.z);
		leftIndex = rightIndex;
		rightIndex--;
		if (rightIndex < 0) {
			rightIndex = layers.Length - 1;
		}
	}

	private void ScrollRight() {
		int lastleft = rightIndex;
		layers[leftIndex].position = new Vector3(layers[leftIndex].position.x + backgroundSize, layers[leftIndex].position.y, layers[leftIndex].position.z);
		rightIndex = leftIndex;
		leftIndex++; 
		if (leftIndex  == layers.Length) {
			leftIndex = 0;
		}
	}
}
