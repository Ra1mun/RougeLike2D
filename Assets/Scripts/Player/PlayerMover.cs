using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Rigidbody2D _rigidbody;
    public void Init(float speed, Rigidbody2D rigidbody)
    {
        _speed = speed;
        _rigidbody = rigidbody;
    }

    public void Move(Vector2 direction)
    {
        direction = direction * _speed;
        _rigidbody.MovePosition(_rigidbody.position + direction);
    }
}
