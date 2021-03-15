using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
[System.Serializable]
public class Inventory : ScriptableObject {

    public item currentItem;
    public List<item> items = new List<item>();
    public int numberOfKeys;
    public int coins;
    public int yemis;
    public float maxMagic = 10;
    public float currentMagic;

    public void OnEnable()
    {
        currentMagic = maxMagic;
    }

    public void ReduceMagic(float magicCost)
    {
        currentMagic -= magicCost;
    }

    public bool CheckForItem(item item)
    {
        if (items.Contains(item))
        {
            return true;
        }
        return false;
    }


    public void AddItem(item itemToAdd)
    {
        //bu item key mi ?,
        if (itemToAdd.isKey)
        {
            numberOfKeys++;
        }
        else
        {
            if (!items.Contains(itemToAdd))
            {
                items.Add(itemToAdd);
            }
        }
    }


}
