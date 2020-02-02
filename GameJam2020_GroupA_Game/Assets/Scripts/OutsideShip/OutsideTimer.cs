using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OutsideTimer : MonoBehaviour
{
    public float maxTime;
    public float curTimeRemaining;

    public Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        calcTime();
        if (curTimeRemaining <= 0)
        {
            //timer is up
            SceneManager.LoadScene("MainShip");
        }
    }

    private void calcTime()
    {
        curTimeRemaining -= Time.deltaTime;
    }
    private void updateText()
    {
        timerText.text = curTimeRemaining.ToString();
    }
}
