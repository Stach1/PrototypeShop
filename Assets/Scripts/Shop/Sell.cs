using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{

    [SerializeField]
    private InventoryManager inventoryManager;

    // When button pressed, sells item and deletes it from inventory
    public void SellItem()
    {

        // Item in slot
        InventoryItem itemInSlot = GetComponentInParent<InventoryItem>();
        Destroy(itemInSlot.gameObject);
    }
}
