using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public void SetVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }

    private void Start()
    {
        float currentVolume;
        audioMixer.GetFloat("volume", out currentVolume);
        Debug.Log("Current volume: " + currentVolume);
    }
}
