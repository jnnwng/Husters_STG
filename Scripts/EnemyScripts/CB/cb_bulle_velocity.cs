using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cb_bulle_velocity : MonoBehaviour {
    public float speed = 10;
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = transform.right * speed * -1;
    }
}
