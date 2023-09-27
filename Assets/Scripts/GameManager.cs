using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;

    public void EndGame()
    {
    
        if(gameHasEnded == false)
        {
        
            gameHasEnded = true;
            Invoke("Restart", restartDelay);

        }

    }

    void Restart()
    {
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
