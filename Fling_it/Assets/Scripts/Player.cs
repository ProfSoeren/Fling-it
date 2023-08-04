using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float addSpeedX;
    public float addSpeedY;
    public float rotation;
    public Rigidbody2D rb;

    void Start()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Spikes"))
        {
            
        }
    }


}
