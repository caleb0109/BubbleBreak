using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
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
}
