using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton3 : MonoBehaviour
{
    [SerializeField] private AudioClip stage3Sound;
    public void RestartStage3()
    {
        Time.timeScale = 1;
        AudioManager.instance.StopMusic();
        SceneManager.LoadSceneAsync(6);
        AudioManager.instance.PlayMusic(stage3Sound);
    }
}
