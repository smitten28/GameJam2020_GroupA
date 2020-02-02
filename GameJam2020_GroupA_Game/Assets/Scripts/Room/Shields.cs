using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shields : MonoBehaviour
{
    private float shieldHealth;
    private bool isActive;
    private void Start()
    {
        transform.parent.GetComponent<GameManager>().updateShield(this.gameObject);
    }
    public void takeDamage(float a)
    {
        shieldHealth -= a;
        if (shieldHealth <= 0)
        {
            shieldHealth = 0;
            isActive = false;
            this.gameObject.GetComponent<BoxCollider2D>().enabled = false;
            transform.Find("Sprite").GetComponent<SpriteRenderer>().enabled = false;
        }
    }
    public void addHealth(float a)
    {
        if (shieldHealth <= 0)
        {
            isActive = true;
            this.gameObject.GetComponent<BoxCollider2D>().enabled = true;
            transform.Find("Sprite").GetComponent<SpriteRenderer>().enabled = true;
        }
        shieldHealth += a;
    }
    public void updateShieldHealth()
    {

    }
}
