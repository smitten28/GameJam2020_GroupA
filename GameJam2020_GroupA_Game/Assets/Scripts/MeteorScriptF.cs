using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScriptF : MonoBehaviour
{
    [SerializeField]
    private float xSpeed;
    [SerializeField]
    private float ySpeed;

    [SerializeField]
    private float range;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Fall();
        Despawn();
    }

    void Fall()
    {
        transform.position = new Vector3(transform.position.x + (xSpeed * Time.deltaTime), transform.position.y - (ySpeed * Time.deltaTime));
    }

    void Despawn()
    {
        if(transform.position.y <= range)
        {
            Destroy(gameObject);
        }
    }
}
