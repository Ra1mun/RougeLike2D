using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Input;
using UnityEngine;

public class PlayerDecorator : MonoBehaviour
{
    [SerializeField] private PlayerProperty _playerProperty;
    [SerializeField] private Player _player;

    private IInput _input;

    public void Init(IInput input)
    {
        _input = input;
    }

    private void Start()
    {
        BindPlayerMover();
        BindPlayerEffects();
        BindPlayer();
    }

    private void BindPlayerMover()
    {
        _playerProperty.PlayerMover.Init(_playerProperty.Speed,
                                        _playerProperty.Rigidbody);
        _input.OnClicked += _playerProperty.PlayerMover.Move;
    }

    private void BindPlayer()
    {
        _player.Init(_playerProperty.MaxHealth,
                    _playerProperty.PlayerMover,
                    _playerProperty.PlayerEffects);
    }

    private void BindPlayerEffects()
    {
        
    }
    private void OnDisable()
    {
        _input.OnClicked -= _playerProperty.PlayerMover.Move;
    }
}
