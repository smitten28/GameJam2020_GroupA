//==========================================================================================
//Author: Ashley Angel
//Date  : 02/01/2020
//Desc  : plays random clips for footstep sounds
//==========================================================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootSteps : MonoBehaviour
{
    [SerializeField] private AudioClip[] clips;

    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void step()
    {
        AudioClip clip = getRandomClip();
        audioSource.PlayOneShot(clip);
    }
    private AudioClip getRandomClip()
    {
        return clips[UnityEngine.Random.Range(0, clips.Length)];
    }

}
