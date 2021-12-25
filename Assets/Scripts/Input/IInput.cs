using System;
using UnityEngine;

namespace Assets.Scripts.Input
{
    public interface IInput
    {
        event Action<Vector2> OnClicked;
    }
}