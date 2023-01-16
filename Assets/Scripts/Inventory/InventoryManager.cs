using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] inventorySlot;
    [SerializeField]
    public GameObject inventoryItemPrefab;

    public void AddItem(Item item)
    {
        for(int i = 0; i < inventorySlot.Length; i++)
        {
            GameObject slot = inventorySlot[i];
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();
            if(itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return;
            }
        }
    }

    void SpawnNewItem(Item item, GameObject slot)
    {
        GameObject newItemObj = Instantiate(inventoryItemPrefab, slot.transform);
        InventoryItem inventoryItem = newItemObj.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }
}
