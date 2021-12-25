using System;
using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(PlayerEffects))]
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour, IDamagable, IHealth
{
    private int _currentHealth;
    private int _maxHealth;
    private PlayerEffects _playerEffects;

    private PlayerMover _playerMover;
    private Rigidbody2D _rigidbody;

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;
        OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
        _playerEffects.AnimateHit();

        if (!IsAlive()) OnDie?.Invoke();
    }

    public event Action<int, int> OnHealthChanged;

    private bool IsAlive()
    {
        return _currentHealth < 0;
    }

    public event Action OnDie;

    public void Init(int maxHealth, float speed)
    {
        _maxHealth = maxHealth;

        _playerMover.Init(speed, _rigidbody);
    }

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    private void DestroyThis()
    {
        _playerEffects.AnimateDie();
        Destroy(gameObject);
    }

    private void Awake()
    {
        _playerMover = GetComponent<PlayerMover>();
        _playerEffects = GetComponent<PlayerEffects>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
}