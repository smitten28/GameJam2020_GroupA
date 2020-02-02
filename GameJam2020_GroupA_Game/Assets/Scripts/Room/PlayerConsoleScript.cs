// =============================================================
// Player script for working with consoles. Consider removing debug before final implementation
// =============================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConsoleScript : MonoBehaviour
{
    private bool isRepairing = false;

    private bool movementEnabled;

    private bool byConsole = false;

    [SerializeField]
    private float repairSpeed;

    private float percentRepair = 0; //This may be obsolete

    private bool isReady = false;

    private GameObject console;



    // Start is called before the first frame update
    void Start()
    {
        movementEnabled = GetComponent<MovementInside>().getMovementEnabled(); // Not sure if this is needed, mostly kept for Syntax
    }

    // Update is called once per frame
    void Update()
    {

        




        // =================================================
        // Player interacts with Console

        if (byConsole)
        {
            

            //------------------------------------------------------------------------------------
            //Get value of repair from nearby console (Have it from initial Collide)
            // -----------------------------------------------------------------------------------



            if (console.GetComponent<ConsoleScript>().getRoomConsoleHealth() >= console.GetComponent<ConsoleScript>().getMaxHealth())
            {
                // NO NEED TO REPAIR CONDITION. UPDATE UI IN LATER EDITION
                Debug.Log("Already Fixed");
            }
            else
            {
                //Console is broken. Option to repair


                if (Input.GetKeyDown(KeyCode.Space))
                {
                    isReady = true;
                }

                if (isReady = true && Input.GetKeyUp(KeyCode.Space))
                {

                    isRepairing = true;

                }

                if (isRepairing)
                {

                    //This is where the repairing goes --------------------------------
                    Debug.Log("Repairing");

                    GetComponent<MovementInside>().setMovementEnabled(false);

                    //Adds Health
                    console.GetComponent<ConsoleScript>().addRoomConsoleHealth(Time.deltaTime * repairSpeed);

                    Debug.Log(console.GetComponent<ConsoleScript>().getRoomConsoleHealth());



                    // Finished
                    if (Input.GetKeyDown(KeyCode.Space) || console.GetComponent<ConsoleScript>().getRoomConsoleHealth() >= console.GetComponent<ConsoleScript>().getMaxHealth())
                    {


                        //Reset for further repairs
                        Debug.Log("Done");
                        isRepairing = false;
                        isReady = false;
                        byConsole = false; //Stops the player from immediately continuing(or getting stuck)
                        if (console.GetComponent<ConsoleScript>().getRoomScript().returnRoomType() == 2)
                        {
                        console.transform.parent.GetComponent<ReactorRoom>().setIsEverRepaired();
                        }

                        GetComponent<MovementInside>().setMovementEnabled(true);
                    }
                }
            }
            //checking for upgrade after is by and has full heal
            if (console.GetComponent<ConsoleScript>().getRoomConsoleHealth() == console.GetComponent<ConsoleScript>().getMaxHealth())
            {

                //the console has max health
                if (Input.GetKeyDown(KeyCode.E))
                {
                    //e is the interact to upgrade console
                    //attept to upgrade the console
                    if (console.GetComponent<ConsoleScript>().getRoomScript().upgradeRoom())
                    {
                        //Debug.Log("Upgraded");
                    }
                    else
                    {
                        //Debug.Log("NoUpgrade");
                    }
                }
            }
        }

        // =============================================================================
    }









    //Console Triggers; Careful!
    // ==============================================================
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Console")
        {

            console = collision.gameObject;

            //These are for getting the repair value, NOT READY YET

            // ScriptName varibaleScriptName = console.GetComponent<ScriptName>();
            //variableScriptName.functionName();


            //Getting Repair Value (Used for first check)
            percentRepair = console.GetComponent<ConsoleScript>().getRoomConsoleHealth();


            Debug.Log("Console True");
            byConsole = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Console")
        {
            Debug.Log("Console False");
            byConsole = false;
        }
    }
    // ================================================================
    public void upgradeRepairSpeed(int a)
    {
        repairSpeed += a;
    }
}