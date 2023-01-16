using System;
using System.Collections.Generic;
using UnityEngine;

// Sprite resolver library
using UnityEngine.U2D.Animation;

public class InventorySlot : MonoBehaviour
{
    // List of all body parts
    [SerializeField]
    private GameObject[] _bodyParts;
    // The body part that's gonna be changed
    private GameObject _correctBodyPart;

    [SerializeField]
    private InventoryManager _inventoryManager;

    // Sprites from the body part
    private SpriteResolver[] _sprites;

    private GameObject _sellButton;
    
    public void ShowButton()
    {
        // Item in slot
        InventoryItem itemInSlot = GetComponentInChildren<InventoryItem>();

        if (itemInSlot != null)
        {
            foreach (Transform child in transform)
            {
                child.gameObject.SetActive(true);
            }
        }
    }

    public void ChangeCloth()
    {
        // Item in slot
        InventoryItem itemInSlot = GetComponentInChildren<InventoryItem>();
        
        // Sell button
        Sell sellvar = GetComponentInChildren<Sell>();
        


        if (itemInSlot != null)
        {
            // Will check the category, depending on the category it'll choose the correct body part
            switch (itemInSlot.item.category)
            {
                case Item.ItemCategory.Bodywear:
                    _correctBodyPart = _bodyParts[0];
                    break;

                case Item.ItemCategory.Footwear:
                    _correctBodyPart = _bodyParts[1];
                    break;

                // Takes the sprite renderer for the headgear obj
                case Item.ItemCategory.Headgear:
                    _correctBodyPart = _bodyParts[2];
                    break;

            }

        // Gets the sprite resolvers from the body part
        _sprites = _correctBodyPart.GetComponentsInChildren<SpriteResolver>();

        // The item's color
        var color = itemInSlot.item.color.ToString();

        // Changes character sprite by changing the category of the item + the color
        foreach (SpriteResolver sprite in _sprites)
        {
            // If the current player's color is equals to the item's color, then it'll reset back to default.
            // Otherwise, change to the item's color.
            // Also checks if it's wearing the item, if it is then item's color will reset back to default
            if(sprite.GetLabel() == color) sprite.SetCategoryAndLabel(sprite.GetCategory(), "White");
            else if(!sellvar.beingSold) sprite.SetCategoryAndLabel(sprite.GetCategory(), color);
        }

        }
    }

}

