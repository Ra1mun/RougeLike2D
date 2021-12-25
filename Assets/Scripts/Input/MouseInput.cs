﻿using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Input;
using UnityEngine;

public class MouseInput : MonoBehaviour, IInput
{
    private const int LeftMouseButton = 0;
    public event Action<Vector2> OnClicked;

    private void Update()
    {
        if (Input.GetMouseButtonDown(LeftMouseButton))
        {
            OnClicked?.Invoke(Input.mousePosition);
        }
    }
}
