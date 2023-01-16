using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Sprite resolver library
using UnityEngine.U2D.Animation;

public class ChangeClothes : MonoBehaviour
{
    // Body part to change
    [SerializeField]
    private Transform _bodyPart;

    // Sprites from the body part
    private SpriteResolver[] _sprites;

    // Category and Labels for each of the body part objects
    //private List<string> _categories = new List<string>();
    //private List<string> _labels = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        // Gets the sprite resolvers from the body part
        _sprites = _bodyPart.GetComponentsInChildren<SpriteResolver>();

        /*for (int i = 0; i < _sprites.Length; i++)
        {
            
            _categories.Add(_sprites[i].GetCategory());
            _labels.Add(_sprites[i].GetLabel());

        }*/
    }

    public void ChangeCloth(string item)
    {
        // Changes character sprite to the one input in the function
        foreach (SpriteResolver sprite in _sprites)
        {
            sprite.SetCategoryAndLabel(sprite.GetCategory(), item);
        }
    }
}
