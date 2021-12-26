using System;
using UnityEngine;

public interface IClick
{
    event Action<Vector3> OnClicked;
}