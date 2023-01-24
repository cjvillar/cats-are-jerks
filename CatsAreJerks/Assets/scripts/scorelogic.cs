using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class scorelogic : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;
    public GameObject gameOverScreen;
    public PlayerController player;
    public Timer time;
    public bool winner = false;
   
    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public bool gameOver()
    {
        gameOverScreen.SetActive(true);
        return true;

    }
    public void win() {
        if (playerScore == 7)
        {
            winner = true;
            player.gameObject.GetComponent<PlayerController>().enabled = false;
            gameOver();
        }

    }


    
    
}