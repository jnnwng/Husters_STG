using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {
    
    public void Play()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
