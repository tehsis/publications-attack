using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeOutMusic : MonoBehaviour {

	private AudioSource music;
	
	void Awake () {
		music = GetComponent<AudioSource>();	
	}
	
	// Update is called once per frame
	void Update () {
	IEnumerator fadeSound1 = AudioFadeOut.FadeOut (music, 10.0f);
	StartCoroutine (fadeSound1);
	StopCoroutine (fadeSound1);	
	}


}

static class AudioFadeOut {
 
    public static IEnumerator FadeOut (AudioSource audioSource, float FadeTime) {
        float startVolume = audioSource.volume;
 
        while (audioSource.volume > 0) {
            audioSource.volume -= startVolume * Time.deltaTime / FadeTime;
 
            yield return null;
        }
 
        audioSource.Stop ();
        audioSource.volume = startVolume;
    }
 
}
