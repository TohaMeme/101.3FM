using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{

    public GameObject InventoryMenu;
    private bool menuActivated;
    public ItemSlot[] itemSlot;
    public List<string> itemsNames = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Inventory") && menuActivated)
        {
            Time.timeScale = 1;
            InventoryMenu.SetActive(false);
            menuActivated = false;
        }

        else if (Input.GetButtonDown("Inventory") && !menuActivated)
        {
            Time.timeScale = 0;
            InventoryMenu.SetActive(true);
            menuActivated = true;
        }
    }

    public void AddItem(string itemName, int quantity, Sprite itemSprite, string itemDescription)
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            if (itemSlot[i].isFull == false) 
            {
                itemSlot[i].AddItem(itemName, quantity, itemSprite, itemDescription);
                itemsNames.Add(itemName);
                return;
                
            }
        }
    }

    private void Awake()
    {
        Lua.RegisterFunction("ItemPicked", this, SymbolExtensions.GetMethodInfo(() => ItemPicked(string.Empty)));
    }

    public bool ItemPicked(string name)
    {
        return itemsNames.Contains(name);
    }

    public void DeselectAllSlots()
    {
        for (int i = 0; i < itemSlot.Length; i++)
        {
            itemSlot[i].selectedShader.SetActive(false) ;
            itemSlot[i].thisItemSelected = false ;
        }
    }
}
