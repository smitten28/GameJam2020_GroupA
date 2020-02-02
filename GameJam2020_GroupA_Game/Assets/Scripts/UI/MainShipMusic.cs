using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShipMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().stop("TitleMusic");
        FindObjectOfType<AudioManager>().play("InsideBackgroundMusic");
        FindObjectOfType<AudioManager>().stop("OutsideBackgroundMusic");
        FindObjectOfType<AudioManager>().playOneShot("OnStartBackgroundMusic");
    }


}
