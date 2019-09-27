using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_enemy_2 : MonoBehaviour {
    public GameObject d;
    public GameObject cb;
    public GameObject cb_2;
    public GameObject cb_3;
    public Vector2 cb_4;//生成的物体
    public GameObject boss;
    private int fs = 1;//生成的方式

    public GameObject[] scq_wz;
    private Vector2[] scqwz;


    void Spawn_0() { }
    //不生成
    void Spawn_a()
    {
        GameObject pr = d;
        switch (Random.Range(0, 4))
        {
            case 0:
                pr = d;
                break;
            case 1:
                pr = cb;
                break;
            case 2:
                pr = cb_2;
                break;
            case 3:
                pr = cb_3;
                break;

        }
        fs = Random.Range(0, 2);
        switch (fs)
        {
            case 0:
                int weizhi1 = Random.Range(0, 5);
                Instantiate(pr, scqwz[weizhi1], Quaternion.identity);
                break;
            case 1:
                int[] weizhi2;
                weizhi2 = new int[2];
                weizhi2[0] = Random.Range(0, 5);
                while (true)
                {
                    weizhi2[1] = Random.Range(0, 5);
                    if (weizhi2[1] != weizhi2[0])
                        break;
                }
                Instantiate(pr, scqwz[weizhi2[0]], Quaternion.identity);
                Instantiate(pr, scqwz[weizhi2[1]], Quaternion.identity);
                break;
        }

    }
    //以方式a生成enemy
    void Spawn_b()
    {
        GameObject pr = d;
        switch (Random.Range(0, 4))
        {
            case 0:
                pr = d;
                break;
            case 1:
                pr = cb;
                break;
            case 2:
                pr = cb_2;
                break;
            case 3:
                pr = cb_3;
                break;

        }
        fs = Random.Range(0, 3);
        switch (fs)
        {
            case 0:
                Instantiate(pr, scqwz[2], Quaternion.identity);
                break;
            case 1:
                Instantiate(pr, scqwz[1], Quaternion.identity);
                Instantiate(pr, scqwz[3], Quaternion.identity);
                break;
            case 2:
                Instantiate(pr, scqwz[1], Quaternion.identity);
                Instantiate(pr, scqwz[2], Quaternion.identity);
                Instantiate(pr, scqwz[3], Quaternion.identity);
                break;
        }

    }
    void Spawn_boss()
    {
        Instantiate(boss, cb_4, Quaternion.identity);
    }
    void Stop_Spawn_Zb()
    {
        CancelInvoke("Spawn_d");
    }
    void Spawn_d()
    {
        GameObject pr = d;
        int o = Random.Range(0, 10);
        if (o >= 0 && o < 2) pr = cb_3;
        else if (o > 1 && o < 5) pr = cb_2;
        else if (o > 4 && o < 8) pr = cb;
        else pr = d;
        Instantiate(pr, scqwz[2], Quaternion.identity).SendMessage("Vv_6_3");
        Instantiate(pr, scqwz[2], Quaternion.identity).SendMessage("Vv_9_3");

    }
    void Spawn_e() { }


    void Start()
    {
        scqwz = new Vector2[scq_wz.Length];
        for (int i = 0; i < scqwz.Length; i++)
            scqwz[i] = scq_wz[i].transform.position;
        //scq_wz = scq.transform.position;
        //将生成器的位置记录下来

        InvokeRepeating("Spawn_d", 0, 2);
    }
    void Update()
    {
    }
}
