using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHealth
{
    event Action<int, int> OnHealthChanged;
}
