using System;
using UnityEngine;

public interface IInput
{
    event Action<Vector2> OnClicked;
}