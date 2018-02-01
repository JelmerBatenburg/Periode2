using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MainAudio : MonoBehaviour {
    public AudioMixer main;
    public Scrollbar slider;
    public string names;


    public void Input()
    {
        main.SetFloat(names, slider.value * - 80);
    }
}
