using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapSpawnScriptF : MonoBehaviour
{
    [SerializeField]
    private GameObject[] scrapPiece;
    [SerializeField]
    private float collectableChance;
    [SerializeField]
    private float cooldown;
    private float timeLeft;

    [SerializeField]
    private Vector2[] range;

    // Start is called before the first frame update
    void Start()
    {
        //SpawnScrap();
    }

    // Update is called once per frame
    void Update()
    {
        SpawnScrap();
    }

    void SpawnScrap()
    {
        float randX;
        float randY;

        if (timeLeft <= 0)
        {
            if (Random.Range(0f, 100f) <= collectableChance)
            {
                randX = Random.Range(range[0].x, range[1].x);
                randY = Random.Range(range[0].y, range[1].y);
                GameObject scrapV = scrapPiece[Random.Range(0, scrapPiece.Length - 1)];
                Instantiate(scrapV, new Vector3(randX, randY, 0), Quaternion.identity);
            }
            timeLeft = cooldown;
        }
        else
        {
            timeLeft -= Time.deltaTime;
        }
    }
}
