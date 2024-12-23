using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : Spawner
{
    protected static BulletSpawner instance;
    public static BulletSpawner Instance => instance;

    public static string bulletOne = "Bullet_1";
    public static string bulletTwo = "Bullet_2";

    protected override void Awake()
    {
        base.Awake();
        if (BulletSpawner.instance != null) Debug.LogWarning("Only 1 BulletSpawner allow to exsit");
        BulletSpawner.instance = this;
    }

}
