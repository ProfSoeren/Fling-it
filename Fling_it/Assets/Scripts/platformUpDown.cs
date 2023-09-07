using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformUpDown : MonoBehaviour
{
    private Touch touch;
    private Vector3 startpos;

    public platformRotation platformRotation;

    private void Start()
    {
        startpos = transform.position;
    }

    void Update()
    {
        if (Input.touchCount > 0 && PauseMenu.GameIsPaused == false)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + touch.deltaPosition.y * platformRotation.sensitivity * 0.001f, transform.position.z);
            }
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, startpos, Time.deltaTime * 10f);
        }
    }
}
