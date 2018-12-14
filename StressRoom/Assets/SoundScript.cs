using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundScript : MonoBehaviour {

    public AudioClip sound;
    AudioSource myAudio;
    public static SoundScript instance;

    void Awake() {
        if (SoundScript.instance == null) {
            SoundScript.instance = this;
        }
    }

	// Use this for initialization
	void Start () {
        myAudio = this.gameObject.GetComponent<AudioSource>();
	}

    public void PlaySound() {
        myAudio.PlayOneShot(sound);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
