using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField] protected bool isShooting = false;
    [SerializeField] protected float shootTimer = 0;
    [SerializeField] protected float shootDelay = 1f;

    protected void FixedUpdate()
    {
        this.IsShooting();
        this.Shooting();
    }
    protected virtual void Shooting()
    {
        if (!this.isShooting) return;

        this.shootTimer += Time.fixedDeltaTime;
        if (this.shootTimer < shootDelay) return;
        this.shootTimer = 0;

        Vector3 spawnPos = transform.parent.position;
        Quaternion spawnRot = transform.parent.rotation;

        //Transform newBullet = Instantiate(this.bulletPrefab,spawnPos,spawnRot);

        Transform newBullet = BulletSpawner.Instance.Spawn(BulletSpawner.bulletOne, spawnPos, spawnRot);
        if (newBullet == null) return;
        newBullet.gameObject.SetActive(true);
        Debug.Log("Shooting");
    }

    protected virtual bool IsShooting()
    {
        this.isShooting = InputManager.Instance.OnFiring == 1;
        return this.isShooting;
    }
}
