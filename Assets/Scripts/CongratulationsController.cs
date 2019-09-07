using UnityEngine;
using TMPro;

public class CongratulationsController : MonoBehaviour {

	[SerializeField] string goodText = "¡Bien!";
	[SerializeField] string excellentText = "¡Excelente!";
	[SerializeField] string perfectText = "¡Increible!";

	[SerializeField] AudioClip goodAudio;
	[SerializeField] AudioClip excellentAudio;
	[SerializeField] AudioClip perfectAudio;

	[SerializeField] AudioSource audioSource;

	TextMeshProUGUI displayText;
	void Awake() {
		displayText = GetComponent<TextMeshProUGUI>();
		displayText.text = "";
	}

	public void displayGoodText() {
		displayText.text = goodText;
		audioSource.PlayOneShot(goodAudio);
		
	}
	public void displayExcellentText() {
		displayText.text = excellentText;
		audioSource.PlayOneShot(excellentAudio);

	}
	public void displayPerfectText() {
		displayText.text = perfectText;
		audioSource.PlayOneShot(perfectAudio);
	}
	
	
}
