using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformUpDown : MonoBehaviour
{
    private Touch touch;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + touch.deltaPosition.y * 0.005f, transform.position.z);
            }
        }
        else
        {

        }
    }
}
