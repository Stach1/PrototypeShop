using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItem : MonoBehaviour
{
    [HideInInspector]
    public Item Item;
    
    private Image _image;

    private void Awake()
    {
        _image = GetComponent<Image>();
    }

    public void InitialiseItem(Item newItem)
    {
        Item = newItem;
        _image.sprite = newItem.icon;
    }
}
