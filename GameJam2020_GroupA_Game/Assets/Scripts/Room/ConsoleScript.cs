using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleScript : MonoBehaviour
{
    private float health = 0; //This is a dummy value, please remove when it has a room for a value

    private RoomScript roomScript;

    // Start is called before the first frame update
    void Start()
    {
        roomScript = transform.parent.gameObject.GetComponent<RoomScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set health equal to room value // Nevermind, it should work without this


        // Make a check so that when the room is dead the console is dead


    }

    public float getRoomConsoleHealth()
    {

        return roomScript.health;
    }

    public void addRoomConsoleHealth(float repairPercent)
    {
        roomScript.addHealth(repairPercent);
    }

    public float getMaxHealth()
    {
        return roomScript.maxHealth;
    }
}
