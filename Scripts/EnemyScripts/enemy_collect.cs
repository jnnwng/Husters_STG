using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_collect : MonoBehaviour {
    void Start()
    {
        GetComponent<Transform>().parent = GameObject.Find("pc_enemy_collection").GetComponent<Transform>();
        //进入场景后父类设置为收集器便于管理
    }
}
