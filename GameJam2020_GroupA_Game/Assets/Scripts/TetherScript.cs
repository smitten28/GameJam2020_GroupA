using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TetherScript : MonoBehaviour
{
    LineRenderer tether;
    [SerializeField]
    GameObject ship;

    // Start is called before the first frame update
    void Start()
    {
        tether = GetComponent<LineRenderer>();
        drawLine();
    }

    // Update is called once per frame
    void Update()
    {
        drawLine();
    }

    void drawLine()
    {
        tether.SetPosition(0, transform.position);
        tether.SetPosition(1, ship.transform.position);
    }
}
