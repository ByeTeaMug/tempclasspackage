using UnityEngine;
using System;
using UnityEngine.PlayerLoop;

[Serializable]
public class TempClassCore
{
    public int value;
    public float alt;
}

public class TempClass : MonoBehaviour
{
    public TempClassCore core;
}
