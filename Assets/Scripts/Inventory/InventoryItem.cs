using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// This script goes in the child for the inventory slot
public class InventoryItem : MonoBehaviour
{
    
    [HideInInspector]
    public Item item;
    
    // Image for the item
    private Image _image;

    private int _itemID;

    private void Awake()
    {
        // UI Image inside the slot
        _image = GetComponent<Image>();
    }

    // Creates item with image in it
    public void InitialiseItem(Item newItem)
    {
        item = newItem;
        _image.sprite = newItem.icon;
        _itemID = newItem.id;
    }

}
