using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CB_2_Bullet_GoBack : MonoBehaviour {

    void GoBack()
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = -gameObject.GetComponent<Rigidbody2D>().velocity;
    }

    void Start()
    {
        Invoke("GoBack", 2f);
    }
}
