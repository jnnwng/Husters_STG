using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pc_bullet_killbullet : MonoBehaviour {
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bulletwall" || other.tag == "Enemy" || other.tag == "boss") Destroy(gameObject);
    }
}
