using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class pointsCtrl : MonoBehaviour {

    public GameObject enemyCreater;
    public Text point;
    public int score = 0;

    void BossSpawn()
    {
        if (Convert.ToInt32(point.text) == 100)
        {
            enemyCreater.SendMessage("Spawn_boss");
            enemyCreater.SendMessage("Stop_Spawn_Zb");
            CancelInvoke("BossSpawn");
        }
    }

    void Zj_1()
    {
        score += 1;
    }
    void Start()
    {

        InvokeRepeating("BossSpawn", 0, 0.1f);
    }
	
	void Update () {
        point.text = score.ToString();
        
	}
}
