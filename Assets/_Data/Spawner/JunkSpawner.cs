using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawner : Spawner
{
    protected static JunkSpawner instance;
    public static JunkSpawner Instance => instance;

    public static string MeteoriteOne = "Meteorite_1";

    protected override void Awake()
    {
        base.Awake();
        if (JunkSpawner.instance != null) Debug.LogWarning("Only 1 JunkSpawner allow to exsit");
        JunkSpawner.instance = this;
    }

}
