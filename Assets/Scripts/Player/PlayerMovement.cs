using UnityEngine;
using Zenject;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour, IInitializable
{
    private float _speed;
    [SerializeField] private Rigidbody2D _rigidbody;

    public void Init(float speed)
    {
        _speed = speed;
    }

    public void Initialize()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        _rigidbody.MovePosition(_rigidbody.position + direction * (_speed * Time.deltaTime));
    }

}