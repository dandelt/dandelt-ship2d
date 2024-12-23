using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DespawnByDistance : Despawn
{
    [SerializeField] protected float distance;
    [SerializeField] protected float distanceLimit = 50f;
    [SerializeField] protected Transform mainCam;

    protected override void LoadComponents()
    {
        base.LoadComponents();
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (this.mainCam != null) return;
        this.mainCam = GameObject.FindObjectOfType<Camera>().transform;
        Debug.Log(transform.name + ": LoadCamera", gameObject);
    }

    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(mainCam.position, transform.parent.position);
        if (this.distance < this.distanceLimit) return false;
        return true;
    }
}
