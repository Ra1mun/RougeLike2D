using System;
using UnityEngine;
using Zenject;

public class IconChooseHandler : IInitializable, IDisposable
{
    private readonly ClickDecorator _clickDecorator;
    private readonly Player _player;

    public IconChooseHandler(ClickDecorator clickDecorator, Player player)
    {
        _clickDecorator = clickDecorator;
        _player = player;
    }

    public void Initialize()
    {
        _player.OnDie += DisableInput;
        _clickDecorator.OnIconClicked += OnIconClicked;
    }

    private void OnIconClicked(Icon icon)
    {
        icon.Scream();
    }

    private void DisableInput()
    {
        _clickDecorator.OnIconClicked -= OnIconClicked;
    }
    
    public void Dispose()
    {
        _clickDecorator.OnIconClicked -= OnIconClicked;
        _player.OnDie -= DisableInput;
    }
}
