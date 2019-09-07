using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndergroundTriggerController : MonoBehaviour {

	[SerializeField] CameraController cameraController;
	[SerializeField] GameObject[] objectsToDisable;
	
	void OnTriggerEnter2D(Collider2D other) {
		cameraController.yMin = -6;
		foreach(GameObject objectToDisable in objectsToDisable) {
			objectToDisable.SetActive(false);
		}
	}
}
