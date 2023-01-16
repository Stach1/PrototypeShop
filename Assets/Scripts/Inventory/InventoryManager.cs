using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    // Inventory Slots for UI
    [SerializeField]
    private InventorySlot[] _inventorySlots;
    [SerializeField]
    public GameObject defaultClothesPrefab;
    // The item prefab that includes the inventoryItem script
    [SerializeField]
    public GameObject inventoryItemPrefab;

    [SerializeField]
    private Item[] _defaultClothes;

    public void AddItem(Item item, bool isDefault)
    {
        // Will check every inventory slot
        for (int i = 0; i < _inventorySlots.Length; i++)
        {
            // Temporary variable for current slot
            InventorySlot slot = _inventorySlots[i];
            // Gets the item from child
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();

            if (isDefault) return;

            // Will check every slot until there's a null one
            else if (itemInSlot == null)
            {
                SpawnNewItem(item, slot, isDefault);
                return;
            }
        }
    }

    // Spawns an item in the required slot
    void SpawnNewItem(Item item, InventorySlot slot, bool isDefault)
    {
        GameObject newItemObj;

        // Creates item prefab in the slot position, checks if its a default cloth first
        // First 2 items will always be in the inventory
        if (isDefault) newItemObj = Instantiate(defaultClothesPrefab, slot.transform);
        else newItemObj = Instantiate(inventoryItemPrefab, slot.transform);



        // Takes the prefab's script and initialises the item
        InventoryItem inventoryItem = newItemObj.GetComponent<InventoryItem>();
        inventoryItem.InitialiseItem(item);
    }

    // For the inventory button
    // When player presses the inventory button
    // First two slots will be default clothes
    public void SetDefault()
    {
        SpawnNewItem(_defaultClothes[0], _inventorySlots[0], true);
        SpawnNewItem(_defaultClothes[1], _inventorySlots[1], true);

    }



    // Unused for now
    public void RemoveItem(Item item)
    {
        // Will check every inventory slot
        for (int i = 0; i < _inventorySlots.Length; i++)
        {
            // Temporary variable for current slot
            InventorySlot slot = _inventorySlots[i];
            // Gets the item from child
            InventoryItem itemInSlot = slot.GetComponentInChildren<InventoryItem>();

            // Will check every slot until it finds the item to delete
            if (itemInSlot != null)
            {
                if (itemInSlot.item.id == item.id)
                {
                    Destroy(itemInSlot.gameObject);
                }

            }

        }
    }

}

