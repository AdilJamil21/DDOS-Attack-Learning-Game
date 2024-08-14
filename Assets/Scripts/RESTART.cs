using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RESTART : MonoBehaviour
{
    public void restartGame()
    {
        Time.timeScale = 1;
        AudioManager.instance.StopMusic();
        SceneManager.LoadSceneAsync(0);
        AudioManager.instance.PlayMusic();
    }
}
