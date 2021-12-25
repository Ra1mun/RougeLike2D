using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Sprites;
using UnityEngine;

public class PlayerProperty : MonoBehaviour
{
    [SerializeField] private int _maxHealth;
    [SerializeField] private float _speed;
    [SerializeField] private PlayerMover _playerMover;
    [SerializeField] private PlayerEffects _playerEffects;
    [SerializeField] private Rigidbody2D _rigidbody;
    public int MaxHealth => _maxHealth;
    public PlayerMover PlayerMover => _playerMover;
    public Rigidbody2D Rigidbody => _rigidbody;
    public float Speed => _speed;
    public PlayerEffects PlayerEffects => _playerEffects;
}
