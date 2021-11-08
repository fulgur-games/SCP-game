using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory
{
    private List<Item> itemList;

    public Inventory()
    {
        AddItem(new Item { itemType = Item.ItemType.Consumable, amount = 1 });
        itemList = new List<Item>();
    }

    public void AddItem(Item _item)
    {
        itemList.Add(_item);
    }

    public List<Item> GetItemList()
    {
        return itemList;
    }
}
