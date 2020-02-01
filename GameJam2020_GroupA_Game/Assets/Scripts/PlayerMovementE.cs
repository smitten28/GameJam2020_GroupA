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

    private float scrapCount;

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


    //Functions 

    void Movement()
    {
        xAxis = Input.GetAxisRaw("Horizontal");
        yAxis = Input.GetAxisRaw("Vertical");

        moveX = xAxis * movementSpeed;
        moveY = yAxis * movementSpeed;

        playerRig.velocity = new Vector2(moveX, moveY);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Collectable")
        {
            Destroy(collision.gameObject);
            float value = collision.gameObject.GetComponent<ScrapScriptE>().getValue();
            scrapCount += value;
            Debug.Log("You have " + scrapCount + " Scrap");
        }
    }
}
