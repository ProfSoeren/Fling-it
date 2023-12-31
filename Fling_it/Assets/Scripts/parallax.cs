using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{

    private float length, startpos, temp, distance;
    //public bool menu;
    public GameObject cam;
    public float parallaxEffect, menuSpeed;
    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {

            temp = (cam.transform.position.x * (1 - parallaxEffect));
            distance = (cam.transform.position.x * parallaxEffect);

            transform.position = new Vector3(startpos + distance, transform.position.y, transform.position.z);

            if (temp > startpos + length) startpos += length;
            else if (temp < startpos - length) startpos -= length;

    }
}
