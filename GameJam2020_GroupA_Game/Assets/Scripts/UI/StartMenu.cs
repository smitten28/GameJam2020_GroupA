using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{

    private Animator playerAnimator;

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void mouseHoverAnimation()
    {
        playerAnimator.SetBool("mouseHover", true);
    }
    public void mouseHoverExitAnimation()
    {
        playerAnimator.SetBool("mouseHover", false);
    }

    public void planet01()
    {
        loadNextScene();
    }
    public void planet02()
    {
        loadNextScene();
    }
    public void planet03()
    {
        loadNextScene();
    }
    public void planet04()
    {
        loadNextScene();
    }
    public void planet05()
    {
        loadNextScene();
    }
    public void exitGame()
    {
        Application.Quit();
    }
    public void loadNextScene()
    {
        SceneManager.LoadScene("MainShip");
    }
}
