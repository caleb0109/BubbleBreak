using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private bool paused = false;
    
    public GameObject pauseMenu;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            paused = togglePause();
        }
    }

    bool togglePause()
    {
        if(Time.timeScale == 0f)
        {
            Time.timeScale = 1f;
            
            pauseMenu.SetActive(false);
            return false;
        }
        else
        {
            Time.timeScale = 0f;
            pauseMenu.SetActive(true);
            return true;
        }
    }

    public void GoToMainMenu(string mainMenu)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(mainMenu);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        paused = false;
        pauseMenu.SetActive(false);
    }

}
