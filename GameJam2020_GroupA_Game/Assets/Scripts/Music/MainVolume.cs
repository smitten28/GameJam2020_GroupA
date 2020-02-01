using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainVolume : MonoBehaviour
{
    [SerializeField] private AudioMixer mixer;
    [SerializeField] Slider slider;
    private float sliderValue;

    public void Start()
    {
        FindObjectOfType<AudioManager>().play("InsideBackgroundMusic");
    }
    public void setVolume()
    {
        sliderValue = slider.value;
        mixer.SetFloat("MusicVol", Mathf.Log10(sliderValue) * 20);
    }

}
