using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementF : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;
    //private float scrapCount; Obselete

    private float xAxis;
    private float yAxis;
    private float moveX;
    private float moveY;

    private Rigidbody2D playerRig;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        playerRig = GetComponent<Rigidbody2D>();

        //gameManager = GameObject.Find("SpaceShip").GetComponent<GameManager>();
        //This doesn't work anymore. Gamemanager was changed
        gameManager = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameManager>();
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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Collectable")
        {

            Destroy(collision.gameObject);
            float value = collision.gameObject.GetComponent<ScrapScriptF>().getValue();
            gameManager.addScrap(value);
            Debug.Log("You now have " + gameManager.returnScrap() + " scrap!");
        }
    }
}
