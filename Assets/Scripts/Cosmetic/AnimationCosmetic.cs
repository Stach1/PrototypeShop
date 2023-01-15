using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCosmetic : MonoBehaviour
{
    [SerializeField]
    private PlayerMov _pMovScript;
    private Animator _anim;

    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        _anim.SetFloat("InputX", _pMovScript.GetInput().x);
        _anim.SetFloat("InputY", _pMovScript.GetInput().y);
    }
}
