using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scorelogic : MonoBehaviour
{
    public int playerScore;
    public TextMeshProUGUI scoreText;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore = playerScore + 1;
        scoreText.text = playerScore.ToString();
        //scoreText.text = string.Format("Score: {0}", playerScore);
    }

}
