using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timers : MonoBehaviour
{
    float currentTime = 0f;
    public float startingTime = 120f;
    [SerializeField] Text countdownText;
    public void Start()
    {
        currentTime = startingTime;
    }
    public void Update()
    {
        if (currentTime > 60)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0");
        }
        else if (currentTime > 0)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = currentTime.ToString("0.0");
        }
        else
        {
            currentTime = 0;
        }
    }


}
