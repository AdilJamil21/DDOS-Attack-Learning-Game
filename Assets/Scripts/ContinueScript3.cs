using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScript3 : MonoBehaviour
{
    [SerializeField] private AudioClip stage3Sound;
    public void Cont()
    {
        AudioManager.instance.StopMusic();
        SceneManager.LoadSceneAsync(6);
        AudioManager.instance.PlayMusic(stage3Sound);
    }
}
