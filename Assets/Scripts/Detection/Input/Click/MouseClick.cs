using System;
using UnityEngine;
using Zenject;

public class MouseClick : IClick, ITickable
{
    private const int LeftMouseButton = 0;

    public event Action<Vector3> OnClicked;

    public void Tick()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton)) OnClicked?.Invoke(Input.mousePosition);
    }
}