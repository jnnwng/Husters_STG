using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CB_3_shooting : MonoBehaviour {
    public GameObject bullet;
    public float bullet_speed = 10f;
    private int n = 0;
    private GameObject pc;
    public int amount = 20;
    public float bullet_t = 0.1f;
    private int i = 0;

    void Changei() { i = 1; }
    void Jyi()
    {
        if (i == 0)
            Invoke("Shoot", 0.9f);
    }


    void Shoot()
    {
        InvokeRepeating("Shooting_once", 0, bullet_t);
    }

    void Shooting_once()
    {
        pc = GameObject.FindWithTag("Player");
        n++;
        if (n == amount)
        {
            n = 0;
            CancelInvoke("Shooting_once");
        }

        Vector3 r;
        if (pc == null)
            r = Vector2.right * -1;

        else
            r = pc.transform.position - transform.position; 
        
        //if (r == null)
        //{
        //    Instantiate(bullet, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = Vector2.right * -1 * bullet_speed;
        //}
        Instantiate(bullet, transform.position, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = r.normalized * bullet_speed;
    }
    void Shoot_v(float t) { Invoke("Shoot", t); }
    void Start ()
    {
        Invoke("Jyi", 0.1f);
        //Invoke("Shoot", 1.5f);
    }
	
	void Update ()
    { 

	}
}
