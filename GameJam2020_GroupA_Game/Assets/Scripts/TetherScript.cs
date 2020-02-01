using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetherScript : MonoBehaviour
{
    [SerializeField] private GameObject linkPrefab;
    [SerializeField] private Vector3 startPos;
    [SerializeField] private float linkLength;
    [SerializeField] private float range;
    [SerializeField] private GameObject ship;

    LineRenderer tether;
    private List<GameObject> links;

    // Start is called before the first frame update
    void Start()
    {
        tether = GetComponent<LineRenderer>();
        links = new List<GameObject>();
        drawTether();
    }

    void drawTether()
    {
        GameObject link = Instantiate(linkPrefab, startPos, Quaternion.identity);
        link.GetComponent<DistanceJoint2D>().enabled = true;
        link.GetComponent<DistanceJoint2D>().connectedBody = ship.GetComponent<Rigidbody2D>();
        links.Add(link);
        startPos.x -= linkLength;

        for (int i = 1; i < range; i++)
        {
            if(i == (range - 1))
            {
                link = Instantiate(linkPrefab, startPos, Quaternion.identity);
                link.GetComponent<HingeJoint2D>().connectedBody = links[i - 1].GetComponent<Rigidbody2D>();
                links.Add(link);
                startPos.x -= linkLength;

                transform.position = startPos;
                GetComponent<HingeJoint2D>().connectedBody = links[i].GetComponent<Rigidbody2D>();
            }
            else
            {
                link = Instantiate(linkPrefab, startPos, Quaternion.identity);
                link.GetComponent<HingeJoint2D>().connectedBody = links[i - 1].GetComponent<Rigidbody2D>();
                links.Add(link);
                startPos.x -= linkLength;
            }
        }
    }
}
