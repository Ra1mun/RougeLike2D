using System;
using UnityEngine;
using Zenject;

public class KeyboardInput : IInput, ITickable
{
    public event Action<Vector2> OnInput;

    public void Tick()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        OnInput?.Invoke(new Vector2(horizontal, vertical));
    }
}
