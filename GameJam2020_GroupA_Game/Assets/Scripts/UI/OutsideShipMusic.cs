﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideShipMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().stop("InsideBackgroundMusic");
        FindObjectOfType<AudioManager>().play("OutsideBackgroundMusic");
    }


}
