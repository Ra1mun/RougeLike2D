using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MovementHandler : IInitializable, IDisposable
{
    private readonly IInput _input;
    private readonly PlayerMovement _playerMovement;
    private readonly Player _player;

    public MovementHandler(IInput input, PlayerMovement playerMovement, Player player)
    {
        _input = input;
        _playerMovement = playerMovement;
        _player = player;
    }

    public void Initialize()
    {
        _input.OnInput += _playerMovement.Move;
        _player.OnDie += DisableInput;
    }

    private void DisableInput()
    {
        _input.OnInput -= _playerMovement.Move;
    }

    public void Dispose()
    {
        _input.OnInput -= _playerMovement.Move;
        _player.OnDie -= DisableInput;
    }
}
