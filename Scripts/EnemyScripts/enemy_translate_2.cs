using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_translate_2 : MonoBehaviour {

    private Rigidbody2D rb;
    public int speed = 2;
    //设定一个值，表示是否处于变向0状态

    void V_up() { rb.velocity = Vector2.left * speed; }
    void V_down() { rb.velocity = Vector2.down * speed; }
    void V_left() { rb.velocity = Vector2.left * speed; }
    void V_right() { rb.velocity = Vector2.right * speed; }
    void V_0() { rb.velocity = Vector2.right * 0; }

    void V_6_3() { rb.velocity = (new Vector2(-10, 6)).normalized * speed; }
    void V_9_3() { rb.velocity = (new Vector2(-10, -6)).normalized * speed; }
    void Vv_6_3() { Invoke("V_up", 0); Invoke("V_6_3", 2); }
    void Vv_9_3() { Invoke("V_up", 0); Invoke("V_9_3", 2); }

    void V_10_7() { rb.velocity = Vector2.down * speed; }
    void V_8_11() { rb.velocity = Vector2.up * speed; }
    void Vv_10_7() { Invoke("V_10_7", 0); }
    void Vv_8_11() { Invoke("V_8_11", 0); }

    void V_2() { Invoke("V_left", 0); Invoke("V_0", 1);Invoke("V_right", 3); }

    void V_3_1() { rb.velocity = new Vector2(-5f - transform.position.x, -6f - transform.position.y).normalized * speed; }
    void Vv_3_1() { Invoke("V_left", 0);Invoke("V_0", 1);Invoke("V_3_1", 2); }
    void V_3_2() { rb.velocity = new Vector2(-5f - transform.position.x, 6f - transform.position.y).normalized * speed; }
    void Vv_3_2() { Invoke("V_left", 0); Invoke("V_0", 1); Invoke("V_3_2", 2); }


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        //进入场景后先给一个向左的加速度
    }
    
    void Update()
    {

    }
}
