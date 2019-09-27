using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PC_shoot : MonoBehaviour
{
    private GameObject gm;
    public GameObject[] bullet;
    private GameObject bullet_0;
    private int q = 0;
    private Rigidbody2D rd;
    private int n = 1;
    public float t = 0.5f;

    private AudioSource asc;
    void Nguiling()
    {
        n = 1;
    }
    void Shoot()
    {
        if (n == 1)
        {
            n++;
            Instantiate(bullet_0, rd.position, Quaternion.identity);
            Invoke("Nguiling", t);
        }

    }
    void Start()
    {
        gm = GameObject.Find("GameManager");
        bullet_0 = bullet[0];
        rd = GetComponent<Rigidbody2D>();
        asc = GetComponent<AudioSource>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            gm.SendMessage("Change_color");
            if (q == 2)
                q = 0;
            else q++;
            bullet_0 = bullet[q];
        }
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Shoot();
        //}

        //if (Input.GetKey(KeyCode.Z))
        //{
        //    Shoot();
        //}
        if (Input.GetKey(KeyCode.J))
        {
            Shoot();
            if (asc.isPlaying == false)
                asc.Play();
        }
    }
}
