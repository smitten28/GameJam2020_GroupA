using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorSpawnScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] meteor;
    [SerializeField]
    private float meteorChance;
    [SerializeField]
    private float cooldown;
    private float timeLeft;

    [SerializeField]
    private Vector2[] range;

    // Start is called before the first frame update
    void Start()
    {
        timeLeft = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnMeteor();
    }

    void SpawnMeteor()
    {
        float randX;
        float randY;

        if(timeLeft <= 0)
        {
            if (Random.Range(0f, 100f) <= meteorChance)
            {
                randX = Random.Range(range[0].x, range[1].x);
                randY = Random.Range(range[0].y, range[1].y);
                GameObject meteorV = meteor[Random.Range(0, meteor.Length - 1)];
                Instantiate(meteorV, new Vector3(randX, randY, 0), Quaternion.identity);
            }
            timeLeft = cooldown;
        }
        else
        {
            timeLeft -= Time.deltaTime;
        }
        
    }
}
