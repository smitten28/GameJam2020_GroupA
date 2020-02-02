using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactorRoom : MonoBehaviour
{
    public float decaySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        reactorDecay();
    }

    private void reactorDecay()
    {
        if (this.gameObject.GetComponent<RoomScript>().returnHealth() > 0)
        {
            this.gameObject.GetComponent<RoomScript>().TakeDamage(decaySpeed * Time.deltaTime);
        }
    }
}
