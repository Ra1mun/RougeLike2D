﻿using System;
using UnityEngine;

public class MoblieInput : MonoBehaviour, IInput
{
    public event Action<Vector2> OnClicked;

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) OnClicked?.Invoke(touch.position);
        }
    }
}