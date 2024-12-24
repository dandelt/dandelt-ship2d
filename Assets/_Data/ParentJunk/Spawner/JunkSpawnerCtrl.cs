using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerCtrl : DanMonoBehaviour
{
    [SerializeField] protected JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner => junkSpawner;

    [SerializeField] protected JunkSpawnPoint junkSpawnPoint;
    public JunkSpawnPoint JunkSpawnPoint => junkSpawnPoint;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawner();
        this.LoadJunkSpawnPoint();
    }
    protected virtual void LoadJunkSpawner()
    {
        if (junkSpawner != null) return;
        this.junkSpawner = GetComponent<JunkSpawner>();
        Debug.Log(transform.name + ": LoadJunkSpawner", gameObject);

    }protected virtual void LoadJunkSpawnPoint()
    {
        if (junkSpawnPoint != null) return;
        this.junkSpawnPoint = GameObject.FindObjectOfType<JunkSpawnPoint>();
        Debug.Log(transform.name + ": LoadJunkSpawnPoint", gameObject);
    }
}
