using PixelCrushers.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField]
    private string itemName;

    [SerializeField]
    private int quantity;

    [SerializeField]
    private Sprite sprite;

    [TextArea]
    [SerializeField]
    private string itemDescription;

    private bool canGrab;

    private InventoryManager inventoryManager;

    // Start is called before the first frame update
    void Start()
    {
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            //inventoryManager.AddItem(itemName, quantity, sprite, itemDescription);
            canGrab= true;

            //GlowController._instance._glowableObjects.Remove(GetComponent<GlowObjectCmd>());
            //Destroy(gameObject);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            canGrab= false;
        }
    }

    private void Update()
    {
        if (canGrab && Input.GetKeyDown(KeyCode.E))
        {
            inventoryManager.AddItem(itemName, quantity, sprite, itemDescription);
            GlowController._instance._glowableObjects.Remove(GetComponent<GlowObjectCmd>());
        }
    }
    /* private void Awake()
      {
          Lua.RegisterFunction("ItemPicked", this, SymbolExtensions.GetMethodInfo(() => ItemPicked(string.Empty)));
      }

      public bool ItemPicked(string name)
      {
          if (name == itemName) return true;
          return false;
      }*/

    /* private void OnEnable()
     {
         Lua.RegisterFunction("ItemPicked", this, SymbolExtensions.GetMethodInfo(() => ItemPicked(string.Empty)));
     }

     private void OnDisable()
     {
         Lua.UnregisterFunction("ItemPicked");
     }*/
}
