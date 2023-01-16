using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{

    [SerializeField]
    private InventoryManager _inventoryManager;

    private InventorySlot _inventorySlot;

    public bool beingSold;

    // When button pressed, sells item and deletes it from inventory
    public void SellItem()
    {
        _inventorySlot = transform.parent.parent.GetComponent<InventorySlot>();
        beingSold = true;
        _inventorySlot.ChangeCloth();
        // Item in slot
        InventoryItem itemInSlot = GetComponentInParent<InventoryItem>();
        Destroy(itemInSlot.gameObject);
    }
}
