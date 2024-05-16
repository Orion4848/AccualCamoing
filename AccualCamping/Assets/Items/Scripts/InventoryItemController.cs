using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemController : MonoBehaviour
{
    // Start is called before the first frame update
    public Item item;
    
    public Button RemoveButton;

    public void RemoveItem()
    {
        InventoryManager.instance.Remove(item);

        Destroy(gameObject);
    }

    public void AddItem(Item newItem)
    {
        item = newItem;
    }
}

