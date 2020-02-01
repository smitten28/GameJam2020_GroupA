using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    public float maxHealth;
    public float health;
    private bool isActive = false;
    private bool islocked = true;
    private int roomType;
    private int maxRoomUpgrades;
    private int roomUpgrade;
    public bool canBeRepaired;

    //
    //defaulted to false for start

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
    }

    public void addHealth(float health)
    {
        if (maxHealth > this.health + health)
        {
            this.health += health;
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


}
