using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMoving : MonoBehaviour
{
    [SerializeField] protected Vector3 tarGetPos;
    [SerializeField] protected float speed=10f;

    protected void FixedUpdate()
    {
        this.GetTargetPos();
        this.LookAtTarget();
        this.Moving();
    }


    protected virtual void GetTargetPos()
    {
        this.tarGetPos = InputManager.Instance.MousePos;
        this.tarGetPos.z = 0;
    }

    protected virtual void LookAtTarget()
    {
        //Calculate the direction from the ship to the mouse position
        Vector3 direction = tarGetPos - transform.position;

        //Calculate the required rotation angle for the ship to look in the direction of the mouse
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        //Apply rotation to the ship
        transform.parent.rotation = Quaternion.Euler(0, 0, angle);
    }
    protected virtual void Moving()
    {
        transform.parent.position = Vector3.Lerp(transform.parent.position, this.tarGetPos, this.speed * Time.fixedDeltaTime);
    }
}
