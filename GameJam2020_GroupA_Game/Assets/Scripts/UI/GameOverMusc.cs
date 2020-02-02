using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverMusc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<AudioManager>().stop("InsideBackgroundMusic");
        FindObjectOfType<AudioManager>().stop("OutsideBackgroundMusic");
        FindObjectOfType<AudioManager>().play("GameOver");
    }


}
