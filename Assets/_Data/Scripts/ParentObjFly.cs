using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentObjFly : DanMonoBehaviour
{
    [SerializeField] protected float speed = 10f;
    [SerializeField] protected Vector3 dir = Vector3.right;

    protected void FixedUpdate()
    {
        this.Fly();
    }
    protected virtual void Fly()
    {
        transform.parent.Translate(this.dir * this.speed * Time.fixedDeltaTime);
    }
}
