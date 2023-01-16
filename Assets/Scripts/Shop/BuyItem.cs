using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    [SerializeField]
    private InventoryManager inventoryManager;
    [SerializeField]
    private Item[] itemsToBuy;

    public void Purchase(int id)
    {
        inventoryManager.AddItem(itemsToBuy[id]);
    }
}