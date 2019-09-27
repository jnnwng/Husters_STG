using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CB_4_shoot : MonoBehaviour {
    public GameObject bullet;
    public float speed = 10f;

    void Changei() { }
    void Shoot_v() { }
    
    void Shoot()
    {
        GameObject[] b = new GameObject[10];
        for (int i = 0; i < 10; i++)
        {
            b[i] = Instantiate(bullet, gameObject.transform.position, Quaternion.identity);
            Vector3 n = new Vector3(Mathf.Sin(0.1744f * i - 0.1744f * 13), Mathf.Cos(0.1744f * i - 0.1744f * 13), 0) * speed;
            b[i].GetComponent<Rigidbody2D>().velocity = n;
        }
    }
    void Start()
    {
        Invoke("Shoot", 1f);
    }
}
