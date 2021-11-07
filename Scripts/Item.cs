using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
    {
        Weapon,                 // peut être jeté mais ne peux pas disparaître après utilisation
        Consumable              // peut être jeté et disparaît après utilisation
    };

    public bool isStackable;    // est-ce que cet item peut être stacké ?
    public bool maxStackAmount; // si oui, jusqu'à combien ?
    public int stackAmount;

    public float weight;        // poids
}
