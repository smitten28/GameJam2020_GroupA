using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementF : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    private float xAxis;
    private float yAxis;
    private float moveX;
    private float moveY;

    private Rigidbody2D playerRig;


    // Start is called before the first frame update
    void Start()
    {
        playerRig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");
        moveX = xAxis * movementSpeed;
        moveY = yAxis * movementSpeed;

        playerRig.velocity = new Vector2(moveX, moveY);
    }
}
