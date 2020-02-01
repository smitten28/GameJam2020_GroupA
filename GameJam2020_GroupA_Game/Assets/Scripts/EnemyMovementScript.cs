using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementScript : MonoBehaviour
{
    private Transform target;
    //can be found on spawn or later
    private int movementtype = 0;
    public float stoppingDistance;
    public float movementSpeed;

    void Start()
    {

    }


    void Update()
    {
        if (movementtype == 0)
        {
            //basic movement type for moving directly to target
            if (checkDistance() > stoppingDistance)
            {
                follow();
            }
        }
    }

    private void follow()
    {
        //moves directly twards target
        transform.position = Vector2.MoveTowards(transform.position, target.position, movementSpeed * Time.deltaTime);
    }

    private float checkDistance()
    {
        return Vector2.Distance(transform.position, target.position);
    }
}
