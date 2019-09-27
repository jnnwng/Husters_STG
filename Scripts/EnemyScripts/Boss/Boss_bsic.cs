using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_bsic : MonoBehaviour {
    
	void Start () {
        GameObject.Find("Main Camera").SendMessage("ChandeClip");
        GameObject.Find("Main Camera").GetComponent<AudioSource>().Play();
        GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemys.Length; i++)
            enemys[i].SendMessage("Dead");

        GameObject[] enemybullets = GameObject.FindGameObjectsWithTag("EnemyB");
        for (int i = 0; i < enemybullets.Length; i++)
            enemybullets[i].SendMessage("Dead");
    }
	
	void Update () {
		
	}
}
