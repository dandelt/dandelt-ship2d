using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnPoint : DanMonoBehaviour
{
    [SerializeField] protected List<Transform> points;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadPoints();
    }
    protected virtual void LoadPoints()
    {
        if (this.points.Count>0) return;
        foreach (Transform chill in transform)
        {
            this.points.Add(chill);
        }
        Debug.Log(transform.name + ": LoadPoints", gameObject);
    }

    public virtual Transform Rand()
    {
        Transform rand = this.points[Random.Range(0, this.points.Count)];
        return rand;
    }
}
