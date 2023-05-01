using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pause : MonoBehaviour
{
    public static bool gameIsPaused;
    public static bool pausemenu;
    public GameObject Panel;

    

    private void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
            pausemenu = !pausemenu;
        }
    }
    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            
        }
        else
        {
            Time.timeScale = 1;
            
        }
        if (pausemenu)
        {
            Panel.SetActive(false);
        }
        else
        {
            Panel.SetActive(true);
        }

    }

    public void quit()
    {
        Application.Quit();
    }

    public void restart()
    {
        
        PlayerStats.playerlives = 3;
        SceneManager.LoadScene(1);
        Time.timeScale = 1;

    }

}
