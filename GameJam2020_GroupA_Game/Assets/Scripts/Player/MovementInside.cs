using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementInside : MonoBehaviour
{
    private bool movementEnabled = true; //True by default, change by the function bello
    
    
    public float MoveHorzspeed;
    private float inputHorz;
    private float inputVert;
    public float MoveVertspeed;
    private bool Ladder = false;
    private Rigidbody2D rb;
    private Animator playerAnimator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerAnimator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (movementEnabled == true)
        {


            inputHorz = Input.GetAxisRaw("Horizontal");
            inputVert = Input.GetAxisRaw("Vertical");

            Debug.Log(inputHorz);

            if (inputHorz == 0)
            {
                Debug.Log("isWalking False");
                playerAnimator.SetBool("isWalking", false);
            }
            else
            {
                Debug.Log("isWalking True");
                playerAnimator.SetBool("isWalking", true);
            }

            rb.velocity = new Vector2(0, 0);


            if (inputHorz != 0 && !Ladder)
            {
                HorizontalMovement();

            }
            else if (inputVert != 0 && Ladder)
            {

                VerticalMovement();


            }



        }
    }

    private void HorizontalMovement()
    {
        
        if (inputHorz != 0 && inputVert == 0)
        {
            rb.velocity = new Vector2(inputHorz * MoveHorzspeed, rb.velocity.y);
            if (inputHorz > 0)
            {
                flipPlayerLeft();
            }
            else if (inputHorz < 0)
            {
                flipPlayerRight();
                
            }
        }
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
    public void onLadder()
    {
        Ladder = true;
    }
    public void offLadder()
    {
        Ladder = false;
    }



    // Changing the state of movementEnabled
    public void setMovementEnabled(bool state)
    {
        movementEnabled = state;
    }

    public bool getMovementEnabled()
    {
        return movementEnabled;
    }


}
