using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private float damageValue;
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLife;
    [SerializeField] private bool targetEnemy;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("decay", bulletLife);
    }

    // Update is called once per frame
    void Update()
    {
        travel();
    }

    void travel()
    {
        transform.Translate(direction * bulletSpeed * Time.deltaTime);
    }

    void decay()
    {
        Destroy(gameObject);
    }

    public void setDirection(Vector3 direction)
    {
        this.direction = direction;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Room" && !targetEnemy)
        {
            collision.gameObject.GetComponent<RoomScript>().TakeDamage(damageValue);
            Destroy(gameObject);
        }

        if(collision.tag == "Shield" && !targetEnemy)
        {
            collision.gameObject.GetComponent<Shields>().takeDamage(damageValue);
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && targetEnemy)
        {
            collision.gameObject.GetComponent<EnemyController>().takeDamage(damageValue);
            Destroy(gameObject);
        }
    }
}
