using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AirTime : MonoBehaviour
{

    public GameObject player;
    public TextMeshProUGUI timerText;
    public float currentTime = 0;


    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 2, player.transform.position.y + 1, player.transform.position.z);
        
    }
}
