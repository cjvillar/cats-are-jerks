using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public GameObject Object;
    public scorelogic score;
    private Timer time;
    private PlayerController player;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("Score").GetComponent<scorelogic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5)
        {
            Destroy(Object);
            score.addScore();
            if (score.playerScore == 7)
            {
                score.gameOver();     
            }


        }
        
  
    }
    
}
