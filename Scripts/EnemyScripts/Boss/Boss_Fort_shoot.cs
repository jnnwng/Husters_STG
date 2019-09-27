using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Fort_shoot : MonoBehaviour {
    public GameObject fort_bullet;
    public float fortbullet_speed = 10;  

    void Shoot()
    {
        GameObject[] b = new GameObject[36];
        for (int i = 0; i < 36; i++)
        {
            b[i] = Instantiate(fort_bullet, gameObject.transform.position, Quaternion.identity);
            Vector3 n = new Vector3(Mathf.Sin(0.1744f * i), Mathf.Cos(0.1744f * i), 0) * fortbullet_speed;
            b[i].GetComponent<Rigidbody2D>().velocity = n;
        }
    }
    void SanShoot()
    {
        InvokeRepeating("Shoot", 0, 1.0f);
    }
    void Start () {

        SanShoot();
    }
    void OnDestroy()
    {
    }
	
    
}
