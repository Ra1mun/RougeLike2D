using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Input;
using UnityEngine;
[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(PlayerEffects))]
public class Player : MonoBehaviour, IDamagable, IHealth
{
    private int _maxHealth;
    private int _currentHealth;

    private bool IsAlive() => _currentHealth < 0;

    private PlayerMover _playerMover;
    private PlayerEffects _playerEffects;

    public event Action OnDie; 
    public event Action<int, int> OnHealthChanged;

    public void Init(int maxHealth, PlayerMover playerMover, PlayerEffects playerEffects)
    {
        _maxHealth = maxHealth;

        _playerMover = playerMover;
        _playerEffects = playerEffects;
    }

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;
        OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
        _playerEffects.AnimateHit();

        if (!IsAlive())
        {
            OnDie?.Invoke();
        }
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
    }

}
