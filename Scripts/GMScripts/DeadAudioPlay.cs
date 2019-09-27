using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadAudioPlay : MonoBehaviour {

    private AudioSource asc;

    void Play()
    {
        asc.Play();
    }

	void Start () {
        asc = gameObject.GetComponent<AudioSource>();
	}
}
