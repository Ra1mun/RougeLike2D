using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMover : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;

    public void Init(float speed, Rigidbody2D rigidbody)
    {
        _speed = speed;
        _rigidbody = rigidbody;
    }

    public void Move(Vector2 direction)
    {
        Debug.Log("Move");
        direction = direction * _speed;
        _rigidbody.MovePosition(_rigidbody.position + direction);
    }
}