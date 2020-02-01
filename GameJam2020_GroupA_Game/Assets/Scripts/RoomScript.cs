using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    public float maxHealth;
    public float health;
    private bool isActive = false;
    //defaulted to false for start

    private void Update()
    {
        if (health <= 0)
        {
            isActive = false;
        }    
    }


    public void TakeDamage(int dmg)
    {
        health -= dmg;
    }

    public void addHealth(float health)
    {
        if (maxHealth < this.health + health)
        {
            this.health += health;
        }
        else
        {
            this.health = maxHealth;
        }

    }
}
