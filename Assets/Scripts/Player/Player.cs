using System;
using UnityEngine;

[RequireComponent(typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerEffects))]
public class Player : MonoBehaviour, IDamagable, IHealth
{
    private int _currentHealth;
    private int _maxHealth;

    [SerializeField] private PlayerProperty _playerProperty;
    private PlayerEffects _playerEffects;
    private PlayerMovement _playerMovement;

    public event Action OnDie;
    public event Action<int, int> OnHealthChanged;
    private bool IsAlive()
    {
        return _currentHealth < 0;
    }
        
    public void ApplyDamage(int damage)
    {
        _currentHealth -= damage;
        OnHealthChanged?.Invoke(_currentHealth, _maxHealth);
        _playerEffects.AnimateHit();

        if (!IsAlive())
        {
            OnDie?.Invoke();
            DestroyThis();
        }
    }



    public void Init(int maxHealth, float speed)
    {
        _maxHealth = _playerProperty.MaxHealth;

        _playerMovement.Init(_playerProperty.Speed);
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
        _playerMovement = GetComponent<PlayerMovement>();
        _playerEffects = GetComponent<PlayerEffects>();
    }
}