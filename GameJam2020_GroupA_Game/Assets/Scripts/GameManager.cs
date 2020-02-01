using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public List<GameObject> rooms = new List<GameObject>();
    static private int maxShipPower;
    static private int usableShipPower;
    static private float lifeSupportTime;
    static private int fuel;
    static private int turretActve;
    static private int shieldTotalLevel;
    static private int scrap;
    static private float enemyWaveTime;

    public int returnScrap()
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
    public void addScrap(int a)
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
}
