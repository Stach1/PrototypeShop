using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CosmeticFollow : MonoBehaviour
{
    //Hashing animations for performance
    private static readonly int Idle = Animator.StringToHash("Idle");
    private static readonly int Walk = Animator.StringToHash("Walk");

    // The PlayerMov script to get the mov input
    [SerializeField]
    private PlayerMov _pMovScript;
    private Animator _anim;

    // Start is called before the first frame update
    void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Checks which state the animation is in and sets which animation that's gonna play
        var state = AnimateState();
        _anim.CrossFade(state, 0, 0);
    }

    int AnimateState()
    {
        // Will check whether player is moving or not for the walk animation
        return _pMovScript.GetInput() == Vector2.zero ? Idle : Walk;

    }

}

