using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour
{
    private float shieldHealth;
    private bool isActive;

    public void takeDamage(float a)
    {
        if (shieldHealth - a <= 0)
        {
            shieldHealth = 0;
            isActive = false;
        }
    }
    public void addHealth(float a)
    {
        if (shieldHealth <= 0)
        {
            isActive = true;
        }
        shieldHealth += a;
    }
    public void updateShieldHealth()
    {

    }
}
