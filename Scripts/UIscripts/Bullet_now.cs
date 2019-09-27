using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bullet_now : MonoBehaviour {
    public GameObject bullet_image;
    public Color[] color;
    private int n = 0;
    void Change_color()
    {
        if (n == 2)
            n = 0;
        else n++;
    }
    void Cz()
    {
        n = 0;
    }
    void Start()
    {
    }
    void Update()
    {
        bullet_image.GetComponent<Image>().color = new Color(color[n].r, color[n].g, color[n].b, 1);
    }
}
