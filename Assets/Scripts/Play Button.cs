using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void MainPlayButton()
    {
        //AudioManager.instance.StopMusic();
        SceneManager.LoadSceneAsync(1);

    }

    //public void pauseMusic()
    //{
    //    if (SceneManager.GetActiveScene().buildIndex == 2)
    //    {
    //        AudioManager.instance.GetComponent<AudioSource>().Pause();
    //    }
    //}

    //void Update()
    //{
    //    if (SceneManager.GetActiveScene().name == "DemoArea")
    //    {
    //        AudioManager.instance.GetComponent<AudioSource>().Pause();
    //    }
    //}
}
