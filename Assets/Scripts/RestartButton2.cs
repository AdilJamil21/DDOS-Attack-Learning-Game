using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartButton2 : MonoBehaviour
{
    [SerializeField] private AudioClip stage2Sound;
    public void RestartStage2()
    {
        Time.timeScale = 1;
        AudioManager.instance.StopMusic();
        SceneManager.LoadSceneAsync(4);
        AudioManager.instance.PlayMusic(stage2Sound);
    }
}
