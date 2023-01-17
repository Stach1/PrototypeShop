using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueFadeOut : MonoBehaviour
{
    [SerializeField]
    private GameObject _talkButtonObj;

    private void Awake()
    {

        Destroy(_talkButtonObj);
        Destroy(gameObject, 3f);
        
        
    }
}
