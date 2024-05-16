using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public List<Item> Items = new List<Item>();

    public Transform ItemContent;
    public GameObject InventoryItem;

    public Toggle EnableRemove;
    public InventoryItemController[] inventoryItems;
    private void Awake()
    {
        instance = this;
    }

    public void Add(Item item)
    {
        Items.Add(item);
    }
    public void Remove(Item item)
    {
        Items.Remove(item);
    }
    public void ListItems()
{
    // Clear content before opening
    foreach (Transform item in ItemContent)
    {

        Destroy(item.gameObject);
    }

    foreach (var item in Items)
    {
        GameObject obj = Instantiate(InventoryItem, ItemContent);
        var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
        var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();
        var removeButtonTransform = obj.transform.Find("RemoveButton");

        // Check if components are found before accessing them
        if (itemName != null)
            itemName.text = item.Itemname;

        if (itemIcon != null)
            itemIcon.sprite = item.icon;

        // Activate RemoveButton if necessary
        if (EnableRemove.isOn && removeButtonTransform != null)
        {
            var removeButton = removeButtonTransform.GetComponent<Button>();
            if (removeButton != null)
                removeButton.gameObject.SetActive(true);
        }
    }

    SetInventoryItems();
}
    
    public void EnableItemRemove(){
        if (EnableRemove.isOn){
            foreach (Transform item in ItemContent) {
                item.Find("RemoveButton").gameObject.SetActive(true);

            }
        }
        else{
            foreach (Transform item in ItemContent) {
                item.Find("RemoveButton").gameObject.SetActive(false);
            }
        }
    }
    public void SetInventoryItems()
    {
        inventoryItems = ItemContent.GetComponentsInChildren<InventoryItemController>();
        for  (int i = 0; i < Items.Count; i++)
        {
            inventoryItems[i].AddItem(Items[i]);
        }
    }
}
