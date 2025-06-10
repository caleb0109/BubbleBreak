using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Image settingMenu;
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            settingMenu.enabled = false;
        }
    }

    // Update is called once per frame
    public void GoToScene(string sceneName)
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("You quit the game!");
    }

    public void SettingsMenu()
    {
        settingMenu.enabled = true;
    }


}
