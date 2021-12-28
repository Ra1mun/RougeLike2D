using System;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerEffects))]
[RequireComponent(typeof(PlayerInteract))]
public class Player : MonoBehaviour, IDamagable, IHealth
{
    private int _currentHealth;
    private int _maxHealth;

    [SerializeField] private PlayerProperty _playerProperty;
    private PlayerEffects _playerEffects;
    private PlayerMovement _playerMovement;
    private PlayerInteract _playerInteract;

    public event Action OnDie;
    public event Action<int, int> OnHealthChanged;
    private bool IsAlive()
    {
        return _currentHealth > 0;
    }
        
    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;
        OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
        _playerEffects.AnimateHit();

        if (IsAlive())
        {
            OnDie?.Invoke();
            DestroyThis();
        }
    }

    private void Start()
    {
        _maxHealth = _playerProperty.MaxHealth;
        _currentHealth = _maxHealth;

        _playerMovement.Init(_playerProperty.Speed);
    }

    private void DestroyThis()
    {
        _playerEffects.AnimateDie();
        Destroy(gameObject);
    }

    private void Awake()
    {
        _playerMovement = GetComponent<PlayerMovement>();
        _playerEffects = GetComponent<PlayerEffects>();
        _playerInteract = GetComponent<PlayerInteract>();
    }
}