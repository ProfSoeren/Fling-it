using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{

    private Touch touch;
    //private float rotateSpeed = 10;
    private Quaternion startRotation = new(0f,0f,0f,0f);


    // Update is called once per frame
    void Update()
    {
      if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z + touch.deltaPosition.y * 0.0005f, transform.rotation.w);
            }
        } else
        {
            transform.rotation = startRotation;
        }
    }
}
