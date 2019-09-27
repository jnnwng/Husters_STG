using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CB_2_b : MonoBehaviour {
    public float bullet_2_speed = 5f;

    void Go()
    {
        GetComponent<Rigidbody2D>().velocity = (GameObject.Find("player").transform.position - transform.position).normalized * bullet_2_speed;
    }

	void Start() {
        Invoke("Go", 2.0f);
	}
}
