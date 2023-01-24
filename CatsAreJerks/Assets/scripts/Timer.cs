using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    private float timeValue = 61;
    public TextMeshProUGUI timerText;
    public scorelogic gameOver;
    public PlayerController player;
    public scorelogic score;
    
    
    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
       
        else
        {
            timeValue = 0;
            player.gameObject.GetComponent<PlayerController>().enabled = false;
            gameOver.gameOver();

        }
        DisplayTime(timeValue);
    }

    void DisplayTime(float timeToDisplay)
    {
        if (timeToDisplay < 0 || score.winner || player.loser)
        {
            timeToDisplay = 0;
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        if (seconds < 11 && minutes < 1)
        {
            timerText.color= Color.red;
        }
        else 
        {
            timerText.color= Color.white;   
        }
        
    }

     

}
