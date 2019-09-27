using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pc_bullet_velocity : MonoBehaviour {

    public float speed = 10;
    private Transform bc_t;

    void Dead()
    {
        Destroy(this.gameObject);
    }
	void Start () {
        bc_t = GameObject.Find("pc_bullet_collection").GetComponent<Transform>();
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * speed;
        GetComponent<Transform>().parent = bc_t;
	}
	
	// Update is called once per frame
	void Update () {

        if (GetComponent<Transform>().position.x > 10)
        {
            Dead();
        }
	}
}
