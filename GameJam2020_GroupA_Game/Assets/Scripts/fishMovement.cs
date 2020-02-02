using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fishMovement : MonoBehaviour
{
    Rigidbody2D fishRb;
    //set to negative if facing left.
    public float moveSpeed;
    void Start()
    {
        fishRb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        fishRb.velocity = new Vector2(moveSpeed, fishRb.velocity.y);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("FishTankLeftWall"))
        {
            moveSpeed *= -1;
            //need to do this becuase the fish have an animation
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if(collision.gameObject.CompareTag("FishTankRightWall"))
        {
            moveSpeed *= -1;
            //need to do this becuase the fish have an animation
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
