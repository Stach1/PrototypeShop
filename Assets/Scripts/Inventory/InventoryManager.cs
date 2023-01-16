using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Inventory Slots for UI
    [SerializeField]
    private InventorySlot[] inventorySlots;
    // The item prefab that includes the inventoryItem script
    [SerializeField]
    public GameObject inventoryItemPrefab;


    public void AddItem(Item item)
    {
        // Will check every inventory slot
        for(int i = 0; i < inventorySlots.Length; i++)
        {
            // Temporary variable for current slot
            InventorySlot slot = inventorySlots[i];
            // Gets the item from child
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();

            // Will check every slot until there's a null one
            if(itemInSlot == null)
            {
                SpawnNewItem(item, slot);
                return;
            }
        }
    }

    // Spawns an item in the required slot
    void SpawnNewItem(Item item, InventorySlot slot)
    {
        // Creates item prefab in the slot position
        GameObject newItemObj = Instantiate(inventoryItemPrefab, slot.transform); 

        // Takes the prefab's script and initialises the item
        InventoryItem inventoryItem = newItemObj.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }

}
