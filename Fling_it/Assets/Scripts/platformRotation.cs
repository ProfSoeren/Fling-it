using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformRotation : MonoBehaviour
{

    private Touch touch;
    private Quaternion startrot;

    public float sensitivity = 5f;

    private void Start()
    {
        startrot = transform.rotation;
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(sensitivity);
      if(Input.touchCount > 0 && PauseMenu.GameIsPaused == false)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z + touch.deltaPosition.y * sensitivity * 0.0001f, transform.rotation.w);
            }
        } else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, startrot, Time.deltaTime * 10f);
        }
    }
}
