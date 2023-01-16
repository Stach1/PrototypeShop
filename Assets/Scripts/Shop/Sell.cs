using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sell : MonoBehaviour
{

    [SerializeField]
    private MoneyManager _moneyManager;

    private InventorySlot _inventorySlot;

    [HideInInspector]
    public bool beingSold;

    // When button pressed, sells item and deletes it from inventory
    public void SellItem()
    {
            // Changes clothing in case you sell an item you're already using,
            // Currently takes the inventory slot object to use the function
            _inventorySlot = GetComponent<InventorySlot>();
            beingSold = true;
            _inventorySlot.ChangeCloth();

            // Item in slot
            InventoryItem itemInSlot = GetComponentInChildren<InventoryItem>();

            // Adds coins whenever item is sold
            _moneyManager.AddCoins(itemInSlot.item.startingPrice);
            
            //Removes item from inventory
            Destroy(itemInSlot.gameObject);
        }
 
}

