﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenuMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().play("TitleMusic");
        FindObjectOfType<AudioManager>().stop("GameOver");
    }


}
