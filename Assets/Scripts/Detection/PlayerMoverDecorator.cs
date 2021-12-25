using System;
using UnityEngine;

public class PlayerMoverDecorator : MonoBehaviour
{
    private readonly Camera _camera;
    private readonly IInput _input;

    public PlayerMoverDecorator(IInput input, Camera camera)
    {
        _input = input;
        _camera = camera;
    }

    public event Action<Vector2> OnPlaneClicked;

    private void OnEnable()
    {
        _input.OnClicked += OnClick;
    }

    private void OnClick(Vector2 position)
    {
        var worldPosition = _camera.ScreenToWorldPoint(position);
        var hit = Physics2D.Raycast(worldPosition, Vector2.down);

        if (hit.collider != null)
            if (hit.collider.TryGetComponent<GestureClick>(out var plane))
                OnPlaneClicked?.Invoke(hit.point);
    }

    private void OnDisable()
    {
        _input.OnClicked -= OnClick;
    }
}