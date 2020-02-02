using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Waves : MonoBehaviour
{
    public int maxWaves;
    static public int curWave;
    public float maxTimePerWave;
    public float waveTime;
    public float maxTimeInBetweenWave;
    public float timeBetweenWave;
    public float maxEnemies;
    public GameObject enemy1Prefab;
    public GameObject enemy2Prefab;

    [SerializeField]
    private Vector2[] range;

    [SerializeField]
    private Text waveText;
    [SerializeField]
    private Text timerText;

    private void Start()
    {
        restartTimer();
        spawnEnemy();
    }

    private void Update()
    {
        if (waveTime > 0)
        {
            updateText();

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
        float randX;
        float randY;

        for (int i = 0; i < maxEnemies * curWave / 2; i++)
        {
            //max * cur wave so we have scaling amounts of enemies
            randX = Random.Range(range[0].x, range[1].x);
            randY = Random.Range(range[0].y, range[1].y);
            if (Random.Range(0, 1) == 0)
            {
                //spawn enemy1
                Instantiate(enemy1Prefab, new Vector3(randX, randY, 0), Quaternion.identity);
            }
            else
            {
                //spawn enemy2
                Instantiate(enemy2Prefab, new Vector3(randX, randY, 0), Quaternion.identity);
            }

        }
    }

    private void updateText()
    {
        //timerText.text = waveTime.ToString();
    }
}
