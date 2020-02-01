using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    private GameManager manager;
    public float maxHealth;
    public float health;
    private bool isActive = false;
    private bool islocked = true;
    public int roomType;
    public int maxRoomUpgrades;
    private int roomUpgrade;
    public int upgradeCost;
    public bool canBeRepaired;

    //
    //defaulted to false for start
    private void Start()
    {
        manager = GameObject.Find("SpaceShip").GetComponent<GameManager>();
        manager.addRoom(this.gameObject);
        DontDestroyOnLoad(this.gameObject);
    }
    private void Update()
    {
        if (health <= 0 && isActive)
        {
            isActive = false;
            health = 0;

        }

        if (health > 0 && !isActive)
        {
            isActive = true;

        }
        
    }


    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if (health <= 0)
        {
            isActive = false;
        }
    }

    public void addHealth(float health)
    {
        if (maxHealth > this.health + health)
        {
            //repair has made this max health
            this.health += health;
            isActive = true;
        }
        else
        {
            this.health = maxHealth;
        }
    }

    public int returnRoomType()
    {
        return roomType;
    }
    public int returnRoomUpgrade()
    {
        return roomUpgrade;
    }

    private void upgradeRoom()
    {
        if (maxRoomUpgrades > roomUpgrade + 1)
        {
            //confirmed that it will not upgrade past max
            if (manager.returnScrap() > upgradeCost)
            {
                //you can pay for the upgrade
                roomUpgrade += 1;
                if (roomType == 0)
                {
                    //powerroom
                    manager.addPower(2);
                }
                else if (roomType == 1)
                {
                    //life support
                }
                else if (roomType == 2)
                {
                    //engines
                }
                else if (roomType == 3)
                {
                    //navigation
                }
                else if (roomType == 4)
                {
                    //airlock
                }
                else if (roomType == 5)
                {
                    //turrets
                    manager.addTurret(2);
                }
                else if (roomType == 6)
                {
                    //sheilds
                    manager.addShield(2);
                }

                manager.subtrScrap(upgradeCost);
            }
        }
    }
}
