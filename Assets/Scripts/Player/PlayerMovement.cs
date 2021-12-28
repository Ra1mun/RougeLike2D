using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    private float _speed;
    private Rigidbody2D _rigidbody;

    public void Init(float speed)
    {
        _speed = speed;
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 direction)
    {
        _rigidbody.MovePosition(_rigidbody.position + direction * (_speed * Time.deltaTime));
    }

}