using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleScript : MonoBehaviour
{
    private float health = 100; //This is a dummy value, please remove when it has a room for a value



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Set health equal to room value
        // Make a check so that when the room is dead the console is dead


    }

    public float getRoomConsoleHealth()
    {
        return health;
    }

    public void setRoomConsoleHealth(float repairPercent)
    {
        health = repairPercent;
        //Set the health of the room with this value
    }
}
