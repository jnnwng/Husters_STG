using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pc_move : MonoBehaviour {

    public float speed_1 = 10.0f;
    public float speed_2 = 5.0f;
    public float speed;
    private Transform ts;
	void Start () {
        speed = speed_1;
        ts = gameObject.GetComponent<Transform>();
	}
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
            speed = speed_2;
        if (Input.GetKeyUp(KeyCode.LeftShift))
            speed = speed_1;

    }
	void FixedUpdate ()
    {
        
        float v = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float h = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        Vector3 d = ts.position;


        ts.localPosition += new Vector3(h, v, 0);

        //if (Mathf.Abs(ts.position.y) > 3.5f)
        //{
        //    int a;
        //    if (ts.position.y > 4.5f) { a = 1; }
        //    else { a = -1; }

        //    ts.position = new Vector3(d.x, 3.5f * a, 0);
        //}
        //if (Mathf.Abs(ts.position.x) > 8.5f)
        //{
        //    ts.localPosition = new Vector3(8.5f * (ts.localPosition.x > 8.5f ? 1 : -1), d.y, 0);
        //}
    }
}
