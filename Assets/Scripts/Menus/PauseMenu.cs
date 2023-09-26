using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public GameObject pauseMenu;
    public GameObject pauseButton;

    void Start()
    {
        pauseMenu.SetActive(false);
    }


    public void PauseGame()
    {
    
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    
    }

    public void ResumeGame()
    {
    
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
    
    }

    public void MainMenu()
    {
    
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Time.timeScale = 1f;

    }
}
