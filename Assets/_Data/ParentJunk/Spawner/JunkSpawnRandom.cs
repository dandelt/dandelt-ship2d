using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JunkSpawnRandom : DanMonoBehaviour
{
    [SerializeField] protected JunkSpawnerCtrl junkSpawnerCtrl;
    public JunkSpawnerCtrl JunkSpawnerCtrl => junkSpawnerCtrl;
    [SerializeField] protected float randomDelay = 1f;
    [SerializeField] protected float randomTimer = 0f;
    [SerializeField] protected float randomLimit = 9f;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawnerCtrl();
    }
    protected virtual void LoadJunkSpawnerCtrl()
    {
        if (junkSpawnerCtrl != null) return;
        this.junkSpawnerCtrl = GetComponent<JunkSpawnerCtrl>();
        Debug.Log(transform.name + ": JunkSpawnerCtrl", gameObject);
    }

    protected override void Start()
    {
        //this.JunkSpawning();
    }protected virtual void FixedUpdate()
    {
        this.JunkSpawning();
    }

    protected virtual void JunkSpawning()
    {
        if (this.RandomReachLimit()) return;

        this.randomTimer += Time.fixedDeltaTime;
        if (this.randomTimer < this.randomDelay) return;
        this.randomTimer = 0;

        Transform randPoint = this.junkSpawnerCtrl.JunkSpawnPoint.Rand();
        Vector3 pos = randPoint.position;
        Quaternion rot = transform.rotation;

        Transform prefab = this.junkSpawnerCtrl.JunkSpawner.RandomPrefab();
        Transform obj = this.junkSpawnerCtrl.JunkSpawner.Spawn(prefab, pos, rot);
        obj.gameObject.SetActive(true);
        //Invoke(nameof(this.JunkSpawning), 1f);
    }

    protected virtual bool RandomReachLimit()
    {
        int currentJunk = this.junkSpawnerCtrl.JunkSpawner.SpawnedCount;
        return currentJunk >= this.randomLimit;
    }

    
}
