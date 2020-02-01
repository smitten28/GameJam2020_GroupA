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

    private float percentRepair = 0;

    private bool isReady = false;



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



            if (percentRepair >= 100)
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

                    //This is where the repairing goes
                    Debug.Log("Repairing");

                    GetComponent<MovementInside>().setMovementEnabled(false);

                    percentRepair += (Time.deltaTime * repairSpeed);



                    // Finished
                    if (Input.GetKeyDown(KeyCode.Space) || percentRepair >= 100)
                    {
                        //Incase system passes 100%
                        if (percentRepair > 100)
                        {
                            percentRepair = 100;
                            Debug.Log("100");
                        }

                        //Reset for further repairs
                        Debug.Log("Done");
                        isRepairing = false;
                        isReady = false;
                        byConsole = false; //Stops the player from immediately continuing(or getting stuck)

                        //--------------------------------------------------------------------------------------------------------------------
                        //Return repair value to console script (or could constantly return it at percent repair but would need to constantly recieve as well)

                        GetComponent<MovementInside>().setMovementEnabled(true);
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

        GameObject console = collision.gameObject;

        //These are for getting the repair value, NOT READY YET

        // ScriptName varibaleScriptName = console.GetComponent<ScriptName>();
        //variableScriptName.functionName();


        //Getting Repair Value
        percentRepair = collision.gameObject.GetComponent<ConsoleScript>().getRoomConsoleHealth();
       

        if (collision.tag == "Console")
        {
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

}