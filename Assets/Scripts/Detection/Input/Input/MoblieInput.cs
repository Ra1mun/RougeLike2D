using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class MoblieInput : IInput, ITickable
{
    public event Action<Vector2> OnInput;
    public void Tick()
    {
        OnInput?.Invoke(new Vector2());
    }
}
