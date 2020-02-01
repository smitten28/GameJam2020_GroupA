using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapScriptF : MonoBehaviour
{
    [SerializeField] private float value;
    [SerializeField] private float maxSpeed;
    [SerializeField] private float minSpeed;
    private float xSpeed;
    private float ySpeed;

    [SerializeField] private float heightRange;
    private float maxHeight;
    private float minHeight;
    private bool movingDown;

    // Start is called before the first frame update
    void Start()
    {
        maxHeight = transform.position.y + heightRange;
        minHeight = transform.position.y - heightRange;
        //movingDown = true;
    }

    // Update is called once per frame
    void Update()
    {
        Drift();
    }

    void Drift()
    {
        //if(movingDown)
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y - (movementSpeed * Time.deltaTime));

        //    if(transform.position.y <= minHeight)
        //    {
        //        movingDown = false;
        //    }
        //}
        //else
        //{
        //    transform.position = new Vector3(transform.position.x, transform.position.y + (movementSpeed * Time.deltaTime));

        //    if (transform.position.y >= maxHeight)
        //    {
        //        movingDown = true;
        //    }
        //}
        xSpeed = Random.Range(minSpeed, maxSpeed);
        ySpeed = Random.Range(minSpeed, maxSpeed);

        transform.position = new Vector3(transform.position.x + (xSpeed * Time.deltaTime), transform.position.y - (ySpeed * Time.deltaTime));
    }

    public float getValue()
    {
        return value;
    }
}
