using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    [SerializeField]
    private float cost;
    private GameManager gameManager;


    private Animator animator;
    private bool inRange;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        inRange = false;
        gameManager = GameObject.Find("SpaceShip").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inRange && CanAfford() == true)
        {
            gameManager.subtrScrap(cost);
            animator.SetBool("isOpen", true);
            FindObjectOfType<AudioManager>().playOneShot("DoorOpen");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            inRange = false;
        }
    }

    private bool CanAfford()
    {
        if (gameManager.returnScrap() >= cost)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
