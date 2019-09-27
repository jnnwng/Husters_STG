using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CB_shooting : MonoBehaviour {

    public GameObject CBB;
    private int i = 0;

    void Changei() { i = 1; }
    void Jyi() { if(i==0)
            Invoke("Shoot", 0.9f);
    }

    void Shoot()
    {
        Instantiate(CBB, gameObject.transform.position, Quaternion.identity);
    }
    void Shoot_v(float n) { Invoke("Shoot", n); }

	void Start () {
        Invoke("Jyi", 0.1f);
    }
	
}
