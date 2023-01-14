using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    // Character's movement speed
    [SerializeField]
    private float _movSpeed;

    private Rigidbody2D _rb;
    private Vector2 _movInput;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Player's input
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");

        // Normalize input values for any controller
        _movInput = new Vector2(dirX, dirY).normalized;
    }

    private void FixedUpdate()
    {
        // Character movement
        _rb.velocity = _movInput * _movSpeed;
    }


}
