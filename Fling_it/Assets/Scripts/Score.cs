using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{

    public Transform player;
    public TMP_Text scoreText;
    private float savedPosition = 0;
    private float startPosition;


    void Start()
    {
        startPosition = player.position.x;
    }

    void Update()
    {
        if(player.position.x > savedPosition)
        {
            scoreText.text = ((player.position.x - startPosition) * 0.25f).ToString("0");
            savedPosition = player.position.x;
        }
    }
}
