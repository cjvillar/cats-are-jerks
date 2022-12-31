using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    //builds scene number when start button clicked
    public int gameStart;
    public void StartGameScene()
    {
        Debug.Log("CLICKED");
        SceneManager.LoadScene(gameStart);
    }
}
