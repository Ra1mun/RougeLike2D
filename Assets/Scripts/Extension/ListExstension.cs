using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public static class ListExstension
    {
        public static T RandomItem<T>(this List<T> list)
        {
            var index = Random.Range(0, list.Count);
            return list[index];
        }
    }
}