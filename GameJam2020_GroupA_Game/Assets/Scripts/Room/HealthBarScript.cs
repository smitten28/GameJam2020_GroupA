﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarScript : MonoBehaviour
{

    private RoomScript roomScript;

    private Transform bar;

    private Transform background;

    private Color colGreen = new Color32(19, 142, 14, 255);

    private Color colGrey = new Color32(53, 53, 53, 255);

    // Start is called before the first frame update
    void Start()
    {
        roomScript = transform.parent.gameObject.GetComponent<RoomScript>();

        bar = transform.Find("Bar");

        background = transform.Find("Background");
    }

    // Update is called once per frame
    void Update()
    {
        
        bar.localScale = new Vector3(1f, (roomScript.health / roomScript.maxHealth));
        if(roomScript.health <= 0)
        {
            setBackHealthColor(Color.red);
        }
        else if ((roomScript.health / roomScript.maxHealth) * 100 <= 10)
        {
            setHealthColor(Color.red);
            setBackHealthColor(colGrey);
        }
        else if((roomScript.health / roomScript.maxHealth) * 100 <= 35)
        {
            setHealthColor(Color.yellow);
            setBackHealthColor(colGrey);

        }
        else
        {
            setHealthColor(colGreen);
            setBackHealthColor(colGrey);
        }
    }


    private void setHealthColor(Color color)
    {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }

    private void setBackHealthColor(Color color)
    {
        background.GetComponent<SpriteRenderer>().color = color;
    }
}
