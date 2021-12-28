using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeachlessBehavior : ISpeakable
{
    public void Speak()
    {
        Debug.Log("I can't speak");
    }
}
