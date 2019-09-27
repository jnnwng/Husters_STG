using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pc_ctrl : MonoBehaviour {
    private int hp = 1;
    private GameObject gm;
    public GameObject player;
    void Start()
    {
        gm = GameObject.Find("GameManager");
    }
    void Changehp()
    {
        hp = 0;
    }
    void OnDestroy()
    {
        if (hp == 0)
        {
            gm.SendMessage("Cz");
            Instantiate(player, new Vector3(-8, 0, 0), Quaternion.identity);
        }
        //SceneManager.LoadScene(0);
    }
}
