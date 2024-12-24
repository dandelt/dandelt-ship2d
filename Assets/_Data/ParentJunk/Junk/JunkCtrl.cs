using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : DanMonoBehaviour
{
    [SerializeField] protected Transform model;
    public Transform Model => model;

    [SerializeField] protected JunkDespawn junkDespawn;
    public JunkDespawn JunkDespawn  => junkDespawn;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
        this.LoadJunkDespawn();
    }
    protected virtual void LoadModel()
    {
        if (model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }
    protected virtual void LoadJunkDespawn()
    {
        if (this.junkDespawn != null) return;
        this.junkDespawn = transform.GetComponentInChildren<JunkDespawn>();
        Debug.Log(transform.name + ": LoadJunkDespawn", gameObject);
    }
}
