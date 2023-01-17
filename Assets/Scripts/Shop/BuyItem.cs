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
        // If you have enough money, buys item
        if (_moneyManager.RemoveCoins(itemsToBuy[id].startingPrice))
        {
            //If you have inventory space, adds item
            if (_inventoryManager.AddItem(itemsToBuy[id]))
            {
                Debug.Log(itemsToBuy[id].name + " Bought!");
                _inventoryManager.GetSelectedItem().ChangeCloth();
                
            }
            else
            {
                // Adds money back up if inventory is full
                _moneyManager.AddCoins(itemsToBuy[id].startingPrice); Debug.Log("Inventory Full");
            }

        }
        else Debug.Log("You don't have enough money!");
    }

    
}
