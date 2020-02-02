using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShipMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().stop("TitleMusic");
    }


}
