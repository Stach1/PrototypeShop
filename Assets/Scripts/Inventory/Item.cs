using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/Item")]  
public class Item : ScriptableObject
{
    public Sprite icon;
    public ItemType type;
    public float startingPrice;

    public enum ItemType
    {
        Headgear,
        Bodywear,
        Footwear
    }
}
