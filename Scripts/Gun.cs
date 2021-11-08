using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : Item
{
    public GunType gunType;

    private int maxMagCapacity;
    private int maxCapacity;
    private int bullets;
    private float cooldown;
    private float reloadTime;

    private void Start()
    {
        switch(gunType)
        {
            case GunType.Revolver:
                maxMagCapacity = 6;
                maxCapacity = 24;
                cooldown = 1.5f;
                reloadTime = 2.3f;
                break;

            case GunType.Shotgun:
                maxMagCapacity = 2;
                maxCapacity = 16;
                cooldown = 2.5f;
                reloadTime = 3.3f;
                break;

            case GunType.Rifle:
                maxMagCapacity = 64;
                maxCapacity = 256;
                cooldown = 0.3f;
                reloadTime = 2f;
                break;
        }

        bullets = maxMagCapacity;
    }

    private void Update()
    {
        Vector3 distance = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
    }

    private void Shoot()
    {
        bool canShoot;

        if(bullets > 0 && bullets <= maxMagCapacity)
        {
            canShoot = true;
        }
        else
        {
            canShoot = false;
        }

        if(canShoot)
        {
            if(Input.GetButtonDown("mouse 0"))
            {

            }
        }
    }

    public enum GunType
    {
        Revolver,
        Shotgun,
        Rifle
    };
}
