using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;
    public GameObject restartButton;
    public GameObject nextStageButton;
    [SerializeField] private AudioClip gameOverSound;
    [SerializeField] private AudioClip gameWinSound;
    [SerializeField] private float winSoundVolume = 0.05f;
    //[SerializeField] private float loseSoundVolume = -0.5f;
    //public GameObject stage1Object;

    void Start()
    {
        gameOverScreen.SetActive(false);
        restartButton.SetActive(false);
        nextStageButton.SetActive(false);
    }


    public void GameOver()
    {
        DestroyAllPacketsAndMalware();
        AudioManager.instance.PlaySound(gameOverSound);
        Time.timeScale = 0;
        gameOverScreen.SetActive(true);
        Restart();

        //stage1Object.SetActive(false);
    }

    public void Win()
    {
        DestroyAllPacketsAndMalware();
        AudioManager.instance.PlaySound(gameWinSound, winSoundVolume);
        //Time.timeScale = 0;
        nextStageButton.SetActive(true);
    }

    public void Restart()
    {
        //Time.timeScale = 1;
        restartButton.SetActive(true);
    }

    //public void LoadNextStage()
    //{
    //    Debug.Log("Loading next stage...");
    //    Time.timeScale = 1; // Reset the time scale to ensure the game runs in real-time
    //    StartCoroutine(LoadNextScene());
    //}

    //private IEnumerator LoadNextScene()
    //{
    //    yield return new WaitForSecondsRealtime(0.1f); // Short delay to ensure Time.timeScale takes effect
    //    int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

    //    if (nextSceneIndex < SceneManager.sceneCountInBuildSettings)
    //    {
    //        Debug.Log("Loading scene index: " + nextSceneIndex);
    //        SceneManager.LoadScene(nextSceneIndex);
    //    }
    //    else
    //    {
    //        Debug.LogError("No more scenes to load. This was the last stage.");
    //        // Optionally, handle the case where there are no more stages to load
    //    }
    //}

    private void DestroyAllPacketsAndMalware()
    {
        GameObject[] packets = GameObject.FindGameObjectsWithTag("Packet");
        GameObject[] malware = GameObject.FindGameObjectsWithTag("Malware");

        foreach (GameObject packet in packets)
        {
            Destroy(packet);
        }

        foreach (GameObject mal in malware)
        {
            Destroy(mal);
        }
    }
}
