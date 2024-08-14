using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioSource bgmSource;
    public AudioSource sfxSource;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(this.gameObject);
        }
        else 
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }

        bgmSource = GetComponent<AudioSource>();
        sfxSource = gameObject.AddComponent<AudioSource>();

    }
    public void StopMusic()
    {
        bgmSource.Stop();
    }

    public void PlayMusic()
    {
        bgmSource.Play();
    }

    public void PlayMusic(AudioClip clip)
    {
        bgmSource.PlayOneShot(clip);
    }

    public void PlaySound(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    public void PlaySound(AudioClip clip, float volume)
    {
        sfxSource.volume = volume;
        sfxSource.PlayOneShot(clip);
    }
}
