using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_translate : MonoBehaviour {
    
    private Rigidbody2D rb;
    private int c = 0;
    public int speed = 2;
    //设定一个值，表示是否处于变向0状态

    private int Zuobiao()
    {
        if (Random.Range(-1, 1) < 0) return -1;
        else return 1;
    }
    //生成一个-1或1

    void Bianxiang_0()
    {
        Vector2 nv = new Vector2(Zuobiao(), Zuobiao());
        rb.velocity = nv * 3;
        c++;
    }//变向0：自动变向，进入场景后的第一次变向，或撞墙变向后的变向，方向随机，
    void Bianxiang_1()
    {
        Vector2 nv = new Vector2(-1, -1);
        rb.velocity = nv * 3;
    }//变向1左下
    void Bianxiang_2()
    {
        Vector2 nv = new Vector2(-1, 1);
        rb.velocity = nv * 3;
    }//变向2左上
    void Bianxiang_3()
    {
        Vector2 nv = new Vector2(1, -1);
        rb.velocity = nv * 3;
    }//变向3右下
    void Bianxiang_4()
    {
        Vector2 nv = new Vector2(1, 1);
        rb.velocity = nv * 3;
    }//变向4右上
    void Panding()
    {
        if (transform.position.x > 8 && c >= 1)
        {
            float f = Random.Range(1, -1);
            CancelInvoke("Bsianxiang_0");
            if (f > 0)
                Bianxiang_1();
            else Bianxiang_2();

            InvokeRepeating("Bianxiang_0", 2, 1);
        }
        if (transform.position.x < -8 && c >= 1)
        {
            float f = Random.Range(1, -1);
            CancelInvoke("Bianxiang_0");
            if (f > 0)
                Bianxiang_3();
            else Bianxiang_4();

            InvokeRepeating("Bianxiang_0", 2, 1);
        }
        if (transform.position.y > 4 && c >= 1)
        {
            float f = Random.Range(1, -1);
            CancelInvoke("Bianxiang_0");
            if (f > 0)
                Bianxiang_1();
            else Bianxiang_3();

            InvokeRepeating("Bianxiang_0", 2, 1);
        }
        if (transform.position.y < -4 && c >= 1)
        {
            float f = Random.Range(1, -1);
            CancelInvoke("Bianxiang_0");
            if (f > 0)
                Bianxiang_4();
            else Bianxiang_2();
            InvokeRepeating("Bianxiang_0", 2, 1);
        }
    }//判断是否已变向0，若已变向0，触边后先取消变向0，再变向，再重新循环变向0

    void V_6_3() { rb.velocity = (new Vector2(-10, 6)).normalized * speed; }
    void Vv_6_3() { Invoke("V_6_3",2); }
    void V_9_3() { rb.velocity = (new Vector2(-10, -6)).normalized * speed; }
    void Vv_9_3() { Invoke("V_9_3", 2); }

    void Start () {
        
        rb = GetComponent<Rigidbody2D>();

        rb.velocity = transform.right * -1 * 2;
        //进入场景后先给一个向左的加速度
        //InvokeRepeating("Bianxiang_0", 2, 2);
        //每隔两秒进行一次变向0
    }

    // Update is called once per frame
    void Update () {
        //Panding();
        
	}
}
