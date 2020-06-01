using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private const int slots = 8;

    public int publicIndex = 0;

    //public InventoryUI inventoryUI;

    //private List<IInventoryItem> mItems = new List<IInventoryItem>();
    public List<IInventoryItem> mItems = new List<IInventoryItem>();


    public event EventHandler<InventoryEventArgs> ItemAdded;

    public event EventHandler<InventoryEventArgs> ItemRemoved;

    void SetIndex(int index)
    {
        publicIndex = index;
    }

    public void AddItem(IInventoryItem item)
    {

        if (mItems.Count < slots)
        {

            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();

            if (collider.enabled)
            {
                collider.enabled = false;


                mItems.Add(item);
                print(mItems[mItems.Count - 1].Name);
                print(item.Name);
                item.OnPickup();

                //print("item added");

                if (ItemAdded != null)
                {
                    //print("Item added 1= null");
                    ItemAdded(this, new InventoryEventArgs(item));
                }
            }
        }
    }

    public void RemoveItem(IInventoryItem item, int index)
    {
        //print("if?");
        if (mItems.Contains(item))
        {
            //print("if");
            mItems.Remove(item);

            item.OnDrop();

            Collider collider = (item as MonoBehaviour).GetComponent<Collider>();
            if (collider != null)
            {
                collider.enabled = true;
            }

            if (ItemRemoved != null)
            {
                //print(index);
                SetIndex(index);
                ItemRemoved(this, new InventoryEventArgs(item));
            }
        }
    }
}
