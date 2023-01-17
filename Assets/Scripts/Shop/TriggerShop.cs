using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShop : MonoBehaviour
{
    [SerializeField]
    private GameObject _optionsObj;
    [SerializeField]
    private GameObject _inventoryButton;

    public void Options() {
        _optionsObj.SetActive(true);
        _inventoryButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Options();
        }
    }

}
