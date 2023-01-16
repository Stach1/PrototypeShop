using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    [SerializeField]
    private InventoryManager inventoryManager;
    
    //Items list in shop buttons
    [SerializeField]
    private Item[] itemsToBuy;

    // When button pressed, adds item to inventory
    public void Purchase(int id)
    {
        inventoryManager.AddItem(itemsToBuy[id], false);
    }

    
}
