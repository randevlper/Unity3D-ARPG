﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletToPoint : BulletEmitter
{
    [SerializeField]
    private Vector3 _shootPosition;

    public Vector3 ShootPosition
    {
        get { return _shootPosition; }
        set { _shootPosition = value; }
    }
    public GameObject shootObject;

    public override bool Shoot()
    {
        if (!canShoot) { return false; }
        if (bulletManager != null)
        {
            GameObject bull = bulletManager.GetNextBullet();
            if (shootObject != null)
            {
                ShootPosition = shootObject.transform.position;
            }

            if (bull != null)
            {
                Vector3 velocity = MathG.NormalVector(_shootPosition - transform.position);
                bull.GetComponent<Bullet>().Reset(gameObject.transform.position, velocity);
                timer = 0;
                canShoot = false;
                return true;
            }
        }
        return false;
    }
}
