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
    private List<string> _categories = new List<string>();
    private List<string> _labels = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        // Gets the sprite resolvers from the body part
        _sprites = _bodyPart.GetComponentsInChildren<SpriteResolver>();

        for (int i = 0; i < _sprites.Length; i++)
        {
            // Adds the sprite's category and label to the list (needed for the function to swap the body part around)
            _categories.Add(_sprites[i].GetCategory());
            _labels.Add(_sprites[i].GetLabel());

        }
    }

    // Update is called once per frame
    void Update()
    {
        // TEST - whenever you press space, body part changes to the other
        if (Input.GetKeyDown("space"))
        {
            foreach(SpriteResolver sprite in _sprites)
            {
                sprite.SetCategoryAndLabel(sprite.GetCategory(), "Red");
            }
        }
    }

    public void ChangeCloth(Transform bodyPart)
    {
        
    }
}
