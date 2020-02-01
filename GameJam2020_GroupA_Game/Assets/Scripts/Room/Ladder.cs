using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ladder : MonoBehaviour
{
    private GameObject floor;
    private GameObject player;
    private bool playerNearby;
    private bool onLadder;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        floor = transform.parent.GetChild(0).gameObject;
        playerNearby = false;
        onLadder = false;
    }

    private void Update()
    {
        if (playerNearby)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                if(onLadder)
                {
                    Debug.Log("Getting Off Ladder");
                    player.GetComponent<MovementInside>().offLadder();
                    floor.GetComponent<BoxCollider2D>().enabled = true;
                    onLadder = false;
                }
                else
                {
                    Debug.Log("Getting On Ladder");
                    player.GetComponent<MovementInside>().onLadder();
                    floor.GetComponent<BoxCollider2D>().enabled = false;
                    onLadder = true;
                }
            }
        }
        else if(onLadder)
        {
            Debug.Log("Getting Off Ladder");
            player.GetComponent<MovementInside>().offLadder();
            floor.GetComponent<BoxCollider2D>().enabled = true;
            onLadder = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.tag == "Player")
        {
            Debug.Log("Player by ladder");
            playerNearby = true;      
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Player away from ladder");
            playerNearby = false;
        }
    }

}
