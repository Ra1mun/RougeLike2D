using System;
using UnityEngine;
using Zenject;

public class ClickDecorator : IInitializable, IDisposable
{
    private readonly Camera _camera;
    private readonly IClick _click;

    public event Action<Icon> OnIconClicked;

    public ClickDecorator(IClick click, Camera camera)
    {
        _click = click;
        _camera = camera;
    }

    public void Initialize()
    {
        _click.OnClicked += OnClick;
    }

    private void OnClick(Vector3 position)
    {
        var worldPosition = _camera.ScreenToWorldPoint(position);
        var hit = Physics2D.Raycast(worldPosition, Vector2.down);
        if (hit.collider != null)
        {
            if (hit.collider.TryGetComponent<Icon>(out var icon))
            {
                OnIconClicked?.Invoke(icon);
            }
        }
            
    }

    public void Dispose()
    {
        _click.OnClicked -= OnClick;
    }
}