using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInside : MonoBehaviour
{
    public float MoveHorzspeed;
    private float inputHorz;
    private float inputVert;
    public float MoveVertspeed;
    private bool spare;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        inputHorz = Input.GetAxisRaw("Horizontal");
        inputVert = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(0, 0);


        if (inputHorz != 0)
        {
            spare = false;
            HorizontalMovement();

            Debug.Log(0);
        }
        else if (inputVert != 0)
        {
            spare = true;
            VerticalMovement();

            Debug.Log(1);
        }




    }

    private void HorizontalMovement()
    {
        if (inputHorz != 0 && inputVert == 0)
        {
            rb.velocity = new Vector2(inputHorz * MoveHorzspeed, rb.velocity.y);
            if (inputHorz > 0)
            {
                flipPlayerRight();
            }
            else if (inputHorz < 0)
            {
                flipPlayerLeft();
            }
        }
        inputHorz = 0;
    }
    private void flipPlayerLeft()
    {
        transform.eulerAngles = new Vector2(0, 180);
    }
    private void flipPlayerRight()
    {
        transform.eulerAngles = new Vector2(0, 0);
    }

    private void VerticalMovement()
    {
        if (inputVert != 0 && inputHorz == 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, inputVert * MoveVertspeed);
        }
        
    }
}
