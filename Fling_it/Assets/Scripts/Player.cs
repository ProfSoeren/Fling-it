using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private LayerMask platformLayerMask;
    public float addSpeedX;
    public float addSpeedY;
    public float rotation;
    public Rigidbody2D rb;
    public CircleCollider2D circleCollider2d;
    public GameObject airTime;
    private bool airTimeChecker = true;
    public AirTime airTimeScript;
    public Score scoreScript;


    void Start()
    {
        // Vibrator.Vibrate();
        airTime.SetActive(false);
    }

    public bool IsGrounded()
    {
        float extraHeight = 0.2f;
        RaycastHit2D raycastHit = Physics2D.Raycast(circleCollider2d.bounds.center, Vector2.down, circleCollider2d.bounds.extents.y + extraHeight, platformLayerMask);
        Color rayColor;
        if(raycastHit.collider != null)
        {
            rayColor = Color.green;
        }
        else
        {
            rayColor = Color.red;
        }
        Debug.DrawRay(circleCollider2d.bounds.center, Vector2.down * (circleCollider2d.bounds.extents.y + extraHeight), rayColor);
        return raycastHit.collider != null;
    }


    void Update()
    {
        if(IsGrounded() == false && airTimeChecker == false)
        {
            airTimeChecker = true;
            StartCoroutine(AirTime());
        }
        else if(IsGrounded() == true && airTimeChecker == true)
        {
            airTimeChecker = false;
            StartCoroutine(AirTimeEnd());
            airTimeScript.currentTime = 0;
        }
        if(IsGrounded() == false)
        {
            airTimeScript.currentTime = airTimeScript.currentTime + Time.deltaTime;
            airTimeScript.timerText.text = airTimeScript.currentTime.ToString("0.00");
        }

    }

    IEnumerator AirTime()
    {
        yield return new WaitForSeconds(2);
        if(IsGrounded() == false && airTimeScript.currentTime >= 2)
        {
            airTime.SetActive(true);
        }   
    }

    IEnumerator AirTimeEnd()
    {
        yield return new WaitForSeconds(2);
            airTime.SetActive(false);
    }

}
