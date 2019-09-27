using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pc_dead : MonoBehaviour {
    private GameObject deadaudio;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy"|| other.tag == "EnemyB" || other.tag == "boss")
        {
            Dead();
            gameObject.SendMessage("Changehp");
        }
        //if (other.tag == "Enemy") {
        //    Dead();
        //    gameObject.SendMessage("Changehp");
        //}
        //if (other.tag == "EnemyB") {
        //    Dead();
        //    gameObject.SendMessage("Changehp");
        //}
        //if (other.tag == "boss")
        //{
        //    Dead();
        //    gameObject.SendMessage("Changehp");
        //}
    }
    void Start()
    {
        deadaudio = GameObject.Find("DeadAudio");
    }
    void Dead()
    {
        deadaudio.SendMessage("Play");
        Destroy(gameObject);
    }
}
