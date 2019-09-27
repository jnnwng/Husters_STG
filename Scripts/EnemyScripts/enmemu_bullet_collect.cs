using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmemu_bullet_collect : MonoBehaviour {
    
	void Start () {
        GetComponent<Transform>().parent = GameObject.Find("pc_bullet_collection").GetComponent<Transform>();
    }
	
}
