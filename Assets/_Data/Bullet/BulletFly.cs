using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : ParentObjFly
{
    protected override void ResetValue()
    {
        base.ResetValue();
        this.speed = 10f;
    }
}
