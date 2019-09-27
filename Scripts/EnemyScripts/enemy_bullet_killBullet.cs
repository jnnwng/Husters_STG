using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_bullet_killBullet : MonoBehaviour {

    void Dead()
    {
        Destroy(gameObject);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bulletwall"|| other.tag == "Player") Destroy(gameObject);
    }
}
