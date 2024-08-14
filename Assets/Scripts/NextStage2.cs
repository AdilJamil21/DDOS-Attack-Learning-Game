using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage2 : MonoBehaviour
{
    public void NextStageButton2()
    {
        SceneManager.LoadSceneAsync(5);
    }
}
