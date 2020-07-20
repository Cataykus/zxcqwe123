using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private Rigidbody2D _rigidbody;

    private bool _isGround = false;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(_speed * Time.fixedDeltaTime * 100, _rigidbody.velocity.y);

        if (Input.GetKey(KeyCode.Space) && _isGround)
        {
            _rigidbody.AddForce(Vector2.up * _jumpForce * Time.fixedDeltaTime * 1000);
            _isGround = false;
        }

        if (_rigidbody.velocity.y == 0)
        {
            _isGround = true;
        }
    }
}
