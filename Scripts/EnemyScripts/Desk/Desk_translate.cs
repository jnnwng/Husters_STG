using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desk_translate : MonoBehaviour {


    void Dead()
    {
        Destroy(this.gameObject);
    }//自毁

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag=="bullet")
        Dead();
    }

    void Start () {

        GetComponent<Transform>().parent = GameObject.Find("pc_enemy_collection").GetComponent<Transform>();
        //进入场景后父类设置为收集器便于管理
        
    }
	
	// Update is called once per frame
	void Update () {
    }
}
