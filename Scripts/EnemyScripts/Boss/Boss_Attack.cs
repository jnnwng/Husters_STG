using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Attack : MonoBehaviour {
    public GameObject bullet_1_1;
    public GameObject bullet_1_2;
    public GameObject bullet_1_3;
    public GameObject bullet_1_4;
    public GameObject bullet;
    public GameObject bullet_2;
    public GameObject bullet_2_2;
    public GameObject bullet_2_3;
    public float speed = 10f;
    public float speed_2 = 10f;
    public float speed_2_2 = 10f;
    public Vector2[] pos;
    public float movespeed = 10f;
    private Rigidbody2D rd;
    private Transform ts;
    public float time;
    public GameObject fort;
    public int isfort = 0;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "boss_st"&& (rd.velocity == ((pos[3] - pos[0]) / time)))
        {
            switch ((int)Random.Range(0, 4))
            {
                case 0:
                    bullet = bullet_1_1;
                    break;
                case 1:
                    bullet = bullet_1_2;
                    break;
                case 2:
                    bullet = bullet_1_3;
                    break;
                case 3:
                    bullet = bullet_1_4;
                    break;
            }

            
            Instantiate(bullet, ts.position + Vector3.up, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = Vector3.up * speed;

            switch ((int)Random.Range(0, 4))
            {
                case 0:
                    bullet = bullet_1_1;
                    break;
                case 1:
                    bullet = bullet_1_2;
                    break;
                case 2:
                    bullet = bullet_1_3;
                    break;
                case 3:
                    bullet = bullet_1_4;
                    break;
            }
            Instantiate(bullet, ts.position + Vector3.down, Quaternion.identity).GetComponent<Rigidbody2D>().velocity = Vector3.down * speed;
        }
    }

    void Attack_1()
    {
        rd.velocity = (pos[1] - pos[0]) / time;
        Invoke("Attack_2", time);
    }
    void Attack_2()
    {
        rd.velocity = (pos[2] - pos[1]) / time;
        Invoke("Attack_3", time);

    }
    void Attack_3()
    {
        rd.velocity = (pos[0] - pos[2]) / time;
        Invoke("Attack_4", time);
    }
    void Attack_4()
    {
        rd.velocity = (pos[3] - pos[0]) / time;
        Invoke("Attack_5", time);
    }
    void Attack_5()
    {
        rd.velocity = (pos[0] - pos[3]) / time;
        Invoke("End", time);
    }
    void End()
    {
        rd.velocity = new Vector2(0, 0);
    }
    //void StopAttack_1() { CancelInvoke("Attack_1"); }

    void Attack_b() { CancelInvoke("Attack_1"); InvokeRepeating("Attack_b_1", 2, 2); InvokeRepeating("Attack_b_2", 2, 0.3f); InvokeRepeating("Attack_b_3", 2.25f, 0.5f); }
    void Attack_b_1()
    {
        Vector2 pc_pos = GameObject.FindWithTag("Player").GetComponent<Transform>().position;
        GameObject[] b = new GameObject[18];
        for (int i = 0; i < 18; i++)
        {
            b[i] = Instantiate(bullet_2, ts.position, Quaternion.identity);
            Vector3 n = new Vector3(Mathf.Sin(0.3488f * i - 0.3488f * 13), Mathf.Cos(0.3488f * i - 0.3488f * 13), 0) * speed_2;
            b[i].GetComponent<Rigidbody2D>().velocity = n;
        }
    }
    void Attack_b_2()
    {
        GameObject[] b = new GameObject[9];
        for (int i = 0; i < 9; i++)
        {
            b[i] = Instantiate(bullet_2_2, ts.position, Quaternion.identity);
            Vector3 n = new Vector3(Mathf.Sin(0.2326f * i - 0.2326f * 11), Mathf.Cos(0.2326f * i - 0.2326f * 11), 0) * speed_2_2;
            b[i].GetComponent<Rigidbody2D>().velocity = n;
        }
    }
    void Attack_b_3()
    {
        GameObject[] b = new GameObject[10];
        for (int i = 0; i < 9; i++)
        {
            b[i] = Instantiate(bullet_2_2, ts.position, Quaternion.identity);
            Vector3 n = new Vector3(Mathf.Sin(0.2326f * i - 0.2326f * 11 + 0.1163f), Mathf.Cos(0.2326f * i - 0.2326f * 11 + 0.1163f), 0) * speed_2_2;
            b[i].GetComponent<Rigidbody2D>().velocity = n;
        }
    }
    
    void Attack_c()
    {
        rd.velocity = Vector2.up * movespeed;
        Invoke("Attack_c_1", 1);
    }
    void Attack_c_1()
    {
        rd.velocity = Vector2.down * movespeed;
        Invoke("Attack_c_2", 2);
    }
    void Attack_c_2()
    {
        rd.velocity = Vector2.up * movespeed;
        Invoke("Attack_c_3", 1);
    }
    void Attack_c_3()
    {
        rd.velocity = Vector2.zero;
        Invoke("Attack_c", 2);
    }


    void Spawn_Fort()
    {
        if (isfort == 0)
        {
            Instantiate(fort, pos[0] + Vector2.up * 3, Quaternion.identity);
            Instantiate(fort, pos[0] + Vector2.down * 3, Quaternion.identity);
            isfort = 2;
        }
    }

    void ChangeIsFort()
    {
        isfort -= 1;
    }
    void Start () {
        //ts.position = new Vector3(7.5f, 0, 0);
        rd = GetComponent<Rigidbody2D>();
        ts = GetComponent<Transform>();
        InvokeRepeating("Attack_1", 0, 5);
    }
	
}
