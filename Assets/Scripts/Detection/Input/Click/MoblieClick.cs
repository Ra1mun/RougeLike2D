using System;
using UnityEngine;
using Zenject;

public class MoblieClick : IClick, ITickable
{
    public event Action<Vector3> OnClicked;

    public void Tick()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) OnClicked?.Invoke((Vector3)touch.position);
        }
    }
}