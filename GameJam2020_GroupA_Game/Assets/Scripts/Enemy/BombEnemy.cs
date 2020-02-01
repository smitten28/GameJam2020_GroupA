using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombEnemy : MonoBehaviour
{
    Transform target;
    public float movementSpeed;
    public int damage;

    void Start()
    {
        
    }


    void Update()
    {
        follow();

    }

    private void follow()
    {
        //moves directly twards target
        transform.position = Vector2.MoveTowards(transform.position, target.position, movementSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Room")
        {
            collision.gameObject.GetComponent<RoomScript>().TakeDamage(damage);

            Destroy(this.gameObject);
        }
    }
}
