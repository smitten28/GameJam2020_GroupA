using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public List<GameObject> rooms = new List<GameObject>();
    static public GameObject shield;
    static private int maxShipPower;
    static private int usableShipPower;
    static private float lifeSupportTime;
    static private float curLifeSupportTime;
    static private int fuel;
    static private int turretActve;
    static private int shieldTotalLevel;
    static private float scrap = 0;
    static private float enemyWaveTime;
    static private int phase;
    static private float maxWaveTime;
    private void Start()
    {

    }
    private void Update()
    {
        updateTimings();
    }
    public float returnScrap()
    {
        return scrap;
    }
    public int returnFuel()
    {
        return fuel;
    }
    public float returnLifeSupportTime()
    {
        return lifeSupportTime;
    }
    public void updateShield(GameObject a)
    {
        shield = a;
    }
    public int returnUsableShipPower()
    {
        return usableShipPower;
    }
    public int returnTurretsActive()
    {
        return turretActve;
    }
    public void addPower(int a)
    {
        maxShipPower += a;
    }
    public void addTurret(int a)
    {
        turretActve += a;
    }
    public void addShield(int a)
    {
        shieldTotalLevel += a;
    }
    public void addRoom(GameObject a)
    {
        rooms.Add(a);
    }
    public void addScrap(float a)
    {
        scrap += a;
    }
    public void addFuel(int a)
    {
        fuel += a;
    }
    public void subtrScrap(int a)
    {
        scrap -= a;
    }
    public void subtrFuel(int a)
    {
        fuel -= a;
    }
    private void updateTimings()
    {
        if (phase == 0)
        {
            //phase 0 is repair phase
        }
        else if (phase == 1)
        {
            //phase 1 is defense
            enemyWaveTime -= Time.deltaTime;
            if (enemyWaveTime <= 0)
            {
                startEnemyWave();
            }
        }
        else if (phase == 2)
        {

        }
    }
    private void countDownTimer()
    {
        //count down timer for enemy waves

    }
    private void startEnemyWave()
    {

    }
    public void buildRoom(int a)
    {
        //empty room is building another roomtype

    }
    public void addLifeSupportTime(int a)
    {
        lifeSupportTime += a;
    }
    private float averageHealth()
    {
        int i = 0;
        float number = 0;
        foreach (GameObject room in rooms)
        {
            number += room.GetComponent<RoomScript>().returnHealth();
            i++;
        }
        return number / i;
    }
}
