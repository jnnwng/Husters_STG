using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_dead : MonoBehaviour {
    private GameObject gm;
    public float hp = 100;
    private Color nowcolor;
    private SpriteRenderer sr;
    void Dead()
    {
        Destroy(this.gameObject);
        if (hp <= 0)
            gm.SendMessage("Zj_1");
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
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "bulletwall") gameObject.SendMessage("Dead");
        if (other.tag == "bullet")
        {
            CancelInvoke("Bianhuiyanse");
            sr.color = nowcolor;
            hp -= 10;
            sr.color = Color.red;
            Invoke("Bianhuiyanse", 0.1f);
        }
        if (hp <= 0)
            Dead();
    }
}
