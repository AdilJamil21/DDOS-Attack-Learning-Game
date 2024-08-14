using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    public List<DropZone> dropZones;
    public GameObject tempStage;
    public float gameTime = 20f;

    void Start()
    {
        tempStage.SetActive(true);
        StartCoroutine(EndGameTimer());
    }

    public bool AreAllBoxesGreen()
    {
        foreach (var dropZone in dropZones)
        {
            if (!dropZone.IsGreen())
            {
                return false;
            }
        }
        return true;
    }

    public void CheckAnswers()
    {
        foreach (var dropZone in dropZones)
        {
            dropZone.CheckPlacement(dropZone.correctItemType);
        }
    }

    public void ResetPuzzle()
    {
        foreach (var dropZone in dropZones)
        {
            dropZone.ResetColor();
        }
    }

    IEnumerator EndGameTimer()
    {
        yield return new WaitForSeconds(gameTime);
        FindObjectOfType<GameManager>().Win();
    }

    public void StageOver()
    {
        tempStage.SetActive(false);
    }
}
