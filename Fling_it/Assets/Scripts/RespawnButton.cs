using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnButton : MonoBehaviour
{

    private bool grow;

    void Update()
    {

        if (transform.localScale.x >= 0.9f)
        {
            grow = false;
        }

        if (transform.localScale.x <= 0.6f)
        {
            grow = true;
        }

        if (grow == true)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(transform.localScale.x * 1.5f, transform.localScale.y * 1.5f, transform.localScale.z) * 1.5f, Time.deltaTime);
        }
        else
        {
            transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(transform.localScale.x * 0.75f, transform.localScale.y * 0.75f, transform.localScale.z) * 0.75f, Time.deltaTime);
        }


    }
}
