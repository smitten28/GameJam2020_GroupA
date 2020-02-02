using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool gameIsPaused;
    public GameObject pauseMenuUI;
    public GameObject gameUI;


    // Start is called before the first frame update
    private void Awake()
    {
        DontDestroyOnLoad(this);
        gameIsPaused = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(!gameIsPaused)
            {
                pause();
            }
    
        }
    }
    public void pause()
    {
        pauseMenuUI.SetActive(true);
        gameUI.SetActive(false);
        gameIsPaused = true;
        Time.timeScale = 0f;
    }
    public void resume()
    {
        pauseMenuUI.SetActive(false);
        gameUI.SetActive(true);
        gameIsPaused = false;
        Time.timeScale = 1f;

    }
    public void exitGame()
    {
        Application.Quit();
    }
    public bool getGameIsPaused()
    {
        return gameIsPaused;
    }
}
