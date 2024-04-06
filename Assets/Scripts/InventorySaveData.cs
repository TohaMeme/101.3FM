/*using PixelCrushers;
using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySaveData: Saver
{
    public List<string> itemName;

    public override string RecordData()
    {
        var inventory = GetComponent<InventoryManager>();
        var saveData = new InventorySaveData();
        saveData.itemName = new List<string>();
        foreach (var item in inventory.itemSlot)
        {
            saveData.itemName.Add(item.name);
        }
        return SaveSystem.Serialize(saveData); 
    }

    public override void ApplyData(string s)
    {
        if (string.IsNullOrEmpty(s)) return; 
        var inventory = GetComponent<InventoryManager>();
        var saveData = SaveSystem.Deserialize<InventorySaveData>(s);
        if (saveData == null) return; 
        inventory.itemSlot = new List<ItemScriptableObject>();
        foreach (var itemName in saveData.itemName)
        {
            var item = Resources.Load<ItemScriptableObject>(itemName);
            inventory.itemSlot.Add(item);
        }
    }


}*/
