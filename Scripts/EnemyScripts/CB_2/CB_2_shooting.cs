using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CB_2_shooting : MonoBehaviour {
    public GameObject bullet;
    public float speed = 10f;
    private int i = 0;

    void Changei() { i = 1; }
    void Jyi()
    {
        if (i == 0)
            Invoke("Shoot", 0.9f);
    }

    void Shoot_1()
    {
        GameObject[] b = new GameObject[8];
        for(int i = 0; i < 8; i++)
        {
            b[i] =Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            Vector3 n = new Vector3(Mathf.Sin(0.785f * i), Mathf.Cos(0.785f * i), 0) * speed;
            b[i].GetComponent<Rigidbody2D>().velocity = n;
        }
    }

    void Shoot_2()
    {
        GameObject[] b = new GameObject[36];
        for (int i = 0; i < 36; i++)
        {
            b[i] = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            Vector3 n = new Vector3(Mathf.Sin(0.1744f * i), Mathf.Cos(0.1744f * i), 0) * speed;
            b[i].GetComponent<Rigidbody2D>().velocity = n;
        }
    }

    void SanShoot_1()
    {
        InvokeRepeating("Shoot_1", 2f, 0.5f);
    }
    void Shoot()
    {
        Invoke("Shoot_2", 1f);
    }
    void Shoot_v(float t) { Invoke("Shoot", t); }
    void Start()
    {
        Invoke("Jyi", 0.1f);
        //Shoot();
    }
}
