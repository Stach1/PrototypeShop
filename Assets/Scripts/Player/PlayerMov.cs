using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    // Character's movement speed
    [SerializeField]
    private float _movSpeed;

    private Rigidbody2D _rb;
    private Animator _anim;

    // The vector for the inputs made by the player
    private Vector2 _movInput;
    // Saves last input before stopped moving (for animation)
    private Vector2 _lastMovInput;

    // If player not moving (for animations)
    private bool _isIdle;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }

    private void Update()
    {
        MoveInput();
        Animate();
        
    }

    private void FixedUpdate()
    {
        // Character movement
        _rb.velocity = _movInput * _movSpeed;

        if (_isIdle) _rb.velocity = Vector2.zero;
    }

    private void MoveInput()
    {
        // Player's input
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");

        // Normalize input values for any controller
        _movInput = new Vector2(dirX, dirY).normalized;

        // If there's no input then player is idle
        _isIdle = dirX == 0 && dirY == 0;
    }

    void Animate()
    {
        // Takes the player input to choose the animation for the blend tree
        // I used last mov input so when you stop moving it'll choose the right float
        // for the idle animation
        // Example: If you were moving up, the character will choose the idle up animation
        _anim.SetFloat("InputX", _lastMovInput.x);
        _anim.SetFloat("InputY", _lastMovInput.y);

        // If you're idle then animator changes to idle blend tree, otherwise player will keep moving
        // Last mov input gets saved here
        if (_isIdle) _anim.SetBool("isMoving", false); else { _anim.SetBool("isMoving", true); _lastMovInput = _movInput; }
    }
}
