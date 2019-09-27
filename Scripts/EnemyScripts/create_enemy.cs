using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class create_enemy : MonoBehaviour {
    public GameObject d;
    public GameObject cb;
    public GameObject cb_2;
    public GameObject cb_3;
    public GameObject cb_4;//生成的物体
    public Vector2 boss_pos;//boss位置
    public GameObject boss;
    private int fs = 1;//生成的方式
    private GameObject pr;
    private float a = 0;


    public GameObject[] scq_wz;
    private Vector2[] scqwz;

    
    
    void Spawn_boss() { Instantiate(boss, boss_pos, Quaternion.identity); }
    void Stop_Spawn_Zb(){ CancelInvoke("Spawn"); }

    void Spawn_2_1()
    {
        if (pr == cb_2) pr = cb;
        GameObject pr_1 = Instantiate(pr, scqwz[6], Quaternion.identity);
        pr_1.SendMessage("Changei");
        pr_1.SendMessage("Vv_10_7");
        pr_1.SendMessage("Shoot_v", 2f - 0.4f * (a % 5));
        GameObject pr_2 = Instantiate(pr, scqwz[10], Quaternion.identity);
        pr_2.SendMessage("Changei");
        pr_2.SendMessage("Vv_8_11");
        pr_2.SendMessage("Shoot_v", 2f - 0.4f * (a % 5));//2.5 2.6 2.7 2.2 

        a++;
    }
    void Spawn_2(float t)
    {
        for (int j = 0; j < 5; j++)
        {
            Invoke("Spawn_2_1", j * t);
        }
    }

    void Spawn()
    {
        pr = d;
        int o = Random.Range(0, 10);
        if (o >= 0 && o < 2) pr = cb_4;
        else if (o > 1 && o < 4) pr = cb_2;
        else if (o > 3 && o < 6) pr = cb_3;
        else if (o > 5 && o < 8) pr = cb;
        else pr = d;
        fs = Random.Range(0, 5);
        if (fs == 0)//中向左
        {
            Instantiate(pr, scqwz[2], Quaternion.identity).SendMessage("Vv_6_3");
            Instantiate(pr, scqwz[2], Quaternion.identity).SendMessage("Vv_9_3");
        }
        else if (fs == 1)//一排
        {
            Spawn_2(0.5f);
            //Instantiate(pr, scqwz[6], Quaternion.identity).SendMessage("Vv_10_7");
            //Instantiate(pr, scqwz[10], Quaternion.identity).SendMessage("Vv_8_11");
        }
        else if (fs == 2)//右一排
            for (int j = 0; j < 5; j++)
                Instantiate(cb, scqwz[j], Quaternion.identity).SendMessage("V_2");   
        else if (fs == 3)//上下各一
        {
            //Spawn_2(0.5f);
            Instantiate(pr, scqwz[0], Quaternion.identity).SendMessage("Vv_3_1");
            Instantiate(pr, scqwz[4], Quaternion.identity).SendMessage("Vv_3_2");
        }
        else if (fs == 4)//右一排
        {
            //Spawn_2(0.5f);
            if (pr == d)
                pr = cb_4;
            for (int j = 0; j < 5; j++)
                Instantiate(pr, scqwz[j], Quaternion.identity).SendMessage("V_2");
        }
    }


    void Start()
    {
        scqwz = new Vector2[scq_wz.Length];
        for (int i = 0; i < scqwz.Length; i++)
            scqwz[i] = scq_wz[i].transform.position;

        InvokeRepeating("Spawn", 0, 2);
    }
    void Update()
    {
    }
}
