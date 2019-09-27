using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CB_4_Bullet : MonoBehaviour {
    private Rigidbody2D rb;
    private GameObject player;
    public float speed = 2;

    void Stop() { rb.velocity = Vector2.zero; }
    void GoPlayer() { player = GameObject.FindWithTag("Player");rb.velocity = (player.transform.position - transform.position).normalized * speed; }

	void Start () {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Invoke("Stop", 0.1f);
        Invoke("GoPlayer", 1f);
	}
	
}
