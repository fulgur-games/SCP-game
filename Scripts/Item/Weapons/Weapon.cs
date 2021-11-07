using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    public enum AmmoType
    {
        Bullet,         // pour des pistolets, revolvers...
        Shell,          // pour des fusils à pompe, fusils de chasse...
        EnergyCell,     // pour des armes futuristiques
        Fuel            // pour le lance-flammes
    };

    public int maxAmmoCapacity;     // combien d'ammo en tout
    public int ammoCapacity;        // combien d'ammo dans le chargeur

    public float recoil;            // recul
    public float cooldown;          // délai entre chaque tir
    public float reloadTime;        // temps de rechargement
}
