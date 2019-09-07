using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class undergroundRestoreTriggerController : MonoBehaviour {
	[SerializeField] CameraController cameraController;
	[SerializeField] GameObject[] objectsToEnable;
	
	void OnTriggerEnter2D(Collider2D other) {
		cameraController.yMin = 0;
		foreach(GameObject objectToEnable in objectsToEnable) {
			objectToEnable.SetActive(true);
		}
	}
}
