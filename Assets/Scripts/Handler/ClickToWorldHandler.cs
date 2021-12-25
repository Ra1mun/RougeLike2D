using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ClickToWorldHandler : IInitializable, IDisposable
{
    private readonly PlayerMoverDecorator _playerMoverDecorator;
    private readonly Player _player;

    private const int DamagePerClick = 1;

    public ClickToWorldHandler(PlayerMoverDecorator playerDetector, Player player)
    {
        _playerMoverDecorator = playerDetector;
        _player = player;
    }

    public void Initialize()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}
