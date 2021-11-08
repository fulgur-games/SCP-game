using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : GameManager
{  
    public string interactTxt;
    public ItemType itemType;
    public int itemAmount;
    public string itemName;
    public string itemDesc;

    public void OnMouseEnter()
    {
        switch(gameObject.tag)
        {
            case "Readable":
                interactTxt = InteractText.Lire.ToString();
                break;

            case "Usable":
                interactTxt = InteractText.Utiliser.ToString();
                break;
            
            case "Pickable":
                interactTxt = InteractText.Prendre.ToString();
                break;
        }
    }

    public enum ItemType
    {
        Weapon,
        Consumable,
        Pickup
    };

}
