using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHand : MonoBehaviour
{

    public GameObject tutorialHandle;
    public GameObject tutorialHand;
    private Touch touch;
    private bool up;


    void Update()
    {
        if (Input.touchCount > 0 && PauseMenu.GameIsPaused == false)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                
                tutorialHandle.SetActive(false);
                tutorialHand.SetActive(false);

            }
        }

        if(transform.position.y >= 8.20f)
        {
            up = false;
        }

        if (transform.position.y <= 4f)
        {
            up = true;
        }

        if(up == true)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, 8.25f, transform.position.z), Time.deltaTime * 3f);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, 3.95f, transform.position.z), Time.deltaTime * 3f);
        }

    }
}

