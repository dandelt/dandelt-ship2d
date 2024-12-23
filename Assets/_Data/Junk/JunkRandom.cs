using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class JunkRandom : DanMonoBehaviour
{
    [SerializeField] protected JunkSpawnerCtrl ctrl;
    public JunkSpawnerCtrl Ctrl => ctrl;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadJunkSpawnerCtrl();
    }
    protected virtual void LoadJunkSpawnerCtrl()
    {
        if (ctrl != null) return;
        this.ctrl = GetComponent<JunkSpawnerCtrl>();
        Debug.Log(transform.name + ": JunkSpawnerCtrl", gameObject);
    }

    protected override void Start()
    {
        this.JunkSpawning();
    }

    protected virtual void JunkSpawning()
    {
        Transform randPoint = this.ctrl.JunkSpawnPoint.Rand();
        Vector3 pos = randPoint.position;
        Quaternion rot = transform.rotation;
        Transform obj = this.Ctrl.JunkSpawner.Spawn(JunkSpawner.MeteoriteOne, pos, rot);
        obj.gameObject.SetActive(true);
        Invoke(nameof(this.JunkSpawning), 1f);
    }
}
