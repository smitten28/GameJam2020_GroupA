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
        movementEnabled = GetComponent<MovementInside>().getMovementEnabled();
    }

    // Update is called once per frame
    void Update()
    {
        if (byConsole)
        {
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


                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Debug.Log("Done");
                    isRepairing = false;
                    isReady = false;
                    byConsole = false; //THIS WILL NOT LET THE PLAYER TO CONTINUE
                    GetComponent<MovementInside>().setMovementEnabled(true);
                }
            }

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