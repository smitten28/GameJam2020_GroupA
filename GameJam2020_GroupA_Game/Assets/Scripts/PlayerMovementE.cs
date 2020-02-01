// =======================================================================
// Name: Ethan Harbaugh
// Date: 01/31/2020
// Desc: Ethan's personal test script !NOT FOR USE IN THE FINAL VERSION!
// =======================================================================


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementE : MonoBehaviour
{

    [SerializeField]
    private float movementSpeed;
    private Rigidbody2D playerRig;

    // Start is called before the first frame update
    void Start()
    {
        playerRig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
    }


    //Functions 

    void movement()
    {
        float direction = Input.GetAxisRaw("Horizontal");
        float move = direction * movementSpeed * Time.deltaTime;
        playerRig.velocity = new Vector2(move, playerRig.velocity.y);
    }
 }
