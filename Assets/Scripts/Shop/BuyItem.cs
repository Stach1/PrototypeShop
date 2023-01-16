using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    [SerializeField]
    private InventoryManager _inventoryManager;
    [SerializeField]
    private MoneyManager _moneyManager;
    
    //Items list in shop buttons
    [SerializeField]
    private Item[] itemsToBuy;

    // When button pressed, adds item to inventory
    public void Purchase(int id)
    {
        _inventoryManager.AddItem(itemsToBuy[id], false);
        _moneyManager.RemoveCoins(itemsToBuy[id].startingPrice);
    }

    
}
