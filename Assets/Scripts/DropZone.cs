using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler
{
    [SerializeField] private AudioClip correct;
    [SerializeField] private float svolume = 1.5f;
    public enum ItemType
    {
        None,
        Firewall,
        ServerUpgrade,
        Malware,
        Server
    }

    public ItemType correctItemType;
    private Image boxImage;
    private Color defaultColor;
    private bool gameOverCalled = false;

    private void Start()
    {
        boxImage = GetComponent<Image>();
        defaultColor = boxImage.color;
    }

    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            Draggable draggable = eventData.pointerDrag.GetComponent<Draggable>();
            if (draggable != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
                CheckPlacement(eventData.pointerDrag.GetComponent<ItemTypeHolder>().itemType);
            }
        }
    }

    public void CheckPlacement(ItemType placedItemType)
    {
        if (placedItemType == correctItemType)
        {
            AudioManager.instance.PlaySound(correct, svolume);
            boxImage.color = Color.green;
            
        }
        else
        {
            boxImage.color = Color.red;
            FindObjectOfType<PuzzleManager>().StageOver();

            if (!gameOverCalled )
            {
                FindObjectOfType<GameManager>().GameOver();
                gameOverCalled = true;
            }
            
        }
    }

    public bool IsGreen()
    {
        return boxImage.color == Color.green;
    }

    public void ResetColor()
    {
        boxImage.color = defaultColor;
    }


}
