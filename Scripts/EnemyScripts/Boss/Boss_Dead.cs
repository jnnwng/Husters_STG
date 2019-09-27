using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_Dead : MonoBehaviour {
    private GameObject gm;
    public float hp = 100;
    private Color nowcolor;
    private SpriteRenderer sr;
    private GameObject deadAudio;

    void Dead()
    {
        Destroy(gameObject);
        gm.SendMessage("Zj_1");
        gm.SendMessage("E_Back");
        deadAudio.SendMessage("Play");
        GameObject.Find("Main Camera").GetComponent<AudioSource>().Stop();
    }//自毁

    void Bianhuiyanse()
    {
        sr.color = nowcolor;
    }

    void Start()
    {
        gm = GameObject.Find("GameManager");
        sr = gameObject.GetComponent<SpriteRenderer>();
        nowcolor = gameObject.GetComponent<SpriteRenderer>().color;
        deadAudio = GameObject.Find("BossDeadAudio");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "bullet")
        {
            CancelInvoke("Bianhuiyanse");
            sr.color = nowcolor;
            hp -= 10;
            if (hp == 3000)
            {
                gameObject.SendMessage("Spawn_Fort");
            }
            if (hp == 2000)
            {
                gameObject.SendMessage("Attack_b");
            }
            if (hp == 1000)
            {
                gameObject.SendMessage("Attack_c");
            }
            sr.color = Color.red;
            Invoke("Bianhuiyanse", 0.1f);
        }
        if (hp <= 0)
            Dead();
    }
}
