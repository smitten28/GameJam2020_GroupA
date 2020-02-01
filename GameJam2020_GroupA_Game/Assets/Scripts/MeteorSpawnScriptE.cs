// ================================================
// Ethan's meteor spawning script
// ================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnScriptE : MonoBehaviour
{
    [SerializeField]
    private GameObject Meteor;
    [SerializeField]
    private float meteorChance;
    [SerializeField]
    private Vector2[] range;
    [SerializeField]
    private float cooldown;
    private float timeLeft;




    void Start()
    {
        timeLeft = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        spawnMeteor();
    }



    //Functions
    void spawnMeteor()
    {
        float randX;
        float randY;

        if(timeLeft <= 0)
        {
            if (Random.Range(0f, 100f) <= meteorChance)
            {
                randX = Random.Range(range[0].x, range[1].x);
                randY = Random.Range(range[0].y, range[1].y);
                Instantiate(Meteor, new Vector3(randX, randY, 0), Quaternion.identity); // Makes the scrap piece
            }
            timeLeft = cooldown;
        }
        else
        {
            timeLeft -= Time.deltaTime;
        }

    }
}
