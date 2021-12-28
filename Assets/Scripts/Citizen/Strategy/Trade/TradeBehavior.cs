using System;
using UnityEditor;
using UnityEngine;

public class TradeBehavior : ITradable
{
    public void Trade(Player player)
    {
        Debug.Log("I can trade");
    }
}