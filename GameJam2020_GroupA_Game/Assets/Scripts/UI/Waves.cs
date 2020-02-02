using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waves : MonoBehaviour
{
    public int maxWaves;
    public int curWave;
    public float maxTimePerWave;
    public float waveTime;
    public float maxTimeInBetweenWave;
    public float timeBetweenWave;
    public float maxEnemies;

    [SerializeField]
    private Text waveText;
    [SerializeField]
    private Text timerText;


    private void Update()
    {
        if (waveTime > 0)
        {
            updateText();
            spawnEnemy();
            waveTime -= Time.deltaTime;
            if (waveTime <= 0)
            {
                waveText.text = curWave.ToString();
                waveTime = 0;
            }
        }
    }

    public void restartTimer()
    {
        waveTime = maxTimePerWave;
    }

    public void spawnEnemy()
    {
         //start spawning enemies
    }

    private void updateText()
    {
        timerText.text = waveTime.ToString();
    }
}
