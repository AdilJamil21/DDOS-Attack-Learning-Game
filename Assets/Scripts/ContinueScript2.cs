using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueScript2 : MonoBehaviour
{
    [SerializeField] private AudioClip stage2Sound;
    public void Cont()
    {
        AudioManager.instance.StopMusic();
        SceneManager.LoadSceneAsync(4);
        AudioManager.instance.PlayMusic(stage2Sound);
    }
}
