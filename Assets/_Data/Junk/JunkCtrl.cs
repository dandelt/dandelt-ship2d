using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkCtrl : DanMonoBehaviour
{
    [SerializeField] protected Transform model;
    public Transform Model => model;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadModel();
    }
    protected virtual void LoadModel()
    {
        if (model != null) return;
        this.model = transform.Find("Model");
        Debug.Log(transform.name + ": LoadModel", gameObject);
    }
}
