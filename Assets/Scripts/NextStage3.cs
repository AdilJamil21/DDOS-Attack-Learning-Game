using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStage3 : MonoBehaviour
{
    public void NextStageButton3()
    {
        SceneManager.LoadSceneAsync(7);
    }
}
