using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameObject[] rooms;
    private int maxShipPower;
    private int usableShipPower;
    private int lifeSupportTime;
    private int fuel;
    private int turretActve;
    private int shieldTotalLevel;
    private int scrap;
    
    public int returnScrap()
    {
        return scrap;
    }
    public int returnFuel()
    {
        return fuel;
    }
    public int returnLifeSupportTime()
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
}
