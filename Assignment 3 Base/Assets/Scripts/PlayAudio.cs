using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour {

    public AudioClip audio1;
    public AudioClip audio2;

	// Use this for initialization
	void Start () {
        gameObject.GetComponent<AudioSource>().clip = audio1;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
