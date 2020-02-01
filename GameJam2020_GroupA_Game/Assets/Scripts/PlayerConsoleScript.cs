using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConsoleScript : MonoBehaviour
{

    private bool movementEnabled;

    private bool byConsole = false;




    // Start is called before the first frame update
    void Start()
    {
       movementEnabled = GetComponent<MovementInside>().getMovementEnabled();
    }

    // Update is called once per frame
    void Update()
    {
       if (byConsole == true && Input.GetKeyDown(KeyCode.Space))
        {
            repairing();
        }
    }









    //Console Triggers; Careful!
    // ==============================================================
    private void OnTriggerEnter2D(Collider2D collision)
    {

        GameObject console = collision.gameObject;

        //These are for getting the repair value, NOT READY YET

       // ScriptName varibaleScriptName = console.GetComponent<ScriptName>();
       //variableScriptName.functionName();

        if (collision.tag == "Console")
        {
            byConsole = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Console")
        {
            byConsole = false;
        }
    }
    // ================================================================




        //THIS FUNCTION SETS byConsole TO FALSE. Player must leave and re-enter to do it again
    private float repairing()
    {
        float percentRepair = 0;
        bool finished = false;

        while(!Input.GetKeyDown(KeyCode.Space) && finished != true)
        {
            //Insert 
        }

        return percentRepair;
    }
}
