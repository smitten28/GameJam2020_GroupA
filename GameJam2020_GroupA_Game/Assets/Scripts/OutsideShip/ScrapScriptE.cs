// ===================================
// Ethan's Scrap Test Script
// ===================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapScriptE : MonoBehaviour
{

    [SerializeField]
    private float value;
    [SerializeField]
    private float movementSpeed;
    [SerializeField]
    private float heightRange;

    private bool movingDown;

    private float maxHeight;
    private float minHeight;





    // Start is called before the first frame update
    void Start()
    {
        maxHeight = transform.position.y + heightRange;
        minHeight = transform.position.y - heightRange;
        movingDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        Drift();
    }


    //Functions

    void Drift()
    {
        if(movingDown)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (Time.deltaTime * movementSpeed));

            if(transform.position.y <= minHeight)
            {
                movingDown = false;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + (Time.deltaTime * movementSpeed));

            if (transform.position.y >= maxHeight)
            {
                movingDown = true;
            }
        }
    }

    public float getValue()
    {
        return value;
    }

}
