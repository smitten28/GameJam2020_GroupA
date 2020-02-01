using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public int damage;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Room")
        {
            collision.gameObject.GetComponent<RoomScript>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
