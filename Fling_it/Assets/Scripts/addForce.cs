using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{

    public float addSpeedX;
    public float addSpeedY;
    public float rotation;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.velocityX > 0 && rb.velocityX < 5)
        {
            rb.velocityX += addSpeedX;
            rb.rotation -= rotation;
        } else if(rb.velocityX < 0 && rb.velocityX > -5)
        {
            rb.velocityX -= addSpeedX;
        }

        if (rb.velocityY > 0 && transform.position.y < -2)
        {
            rb.velocityY += addSpeedY;
        }

        
    }

}
