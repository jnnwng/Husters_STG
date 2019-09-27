using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgmPlay : MonoBehaviour {

    public AudioClip[] m;
    void ChandeClip()
    {
        gameObject.GetComponent<AudioSource>().clip = m[1];
    }
    public void BGMPause()
    {
        gameObject.GetComponent<AudioSource>().Pause();
    }
    public  void BGMPlay()
    {

        gameObject.GetComponent<AudioSource>().Play();
    }
	void Start () {

        gameObject.GetComponent<AudioSource>().Play();
    }
	
}
