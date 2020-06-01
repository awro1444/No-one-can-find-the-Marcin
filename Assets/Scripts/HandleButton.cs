using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class HandleButton : MonoBehaviour
{

    public Inventory _Inventory;
    public int index = 0;
    public string itemName = "";


    void LateUpdate()
    {
        //clicked = false;
        //highlited = false;
    }

    public void SetName(string name)
    {
        itemName = name;
    }

    public void RemoveName()
    {
        itemName = "";
    }

    public void Click()
    {
        print("clicked!");
        //Image image = this.GetComponent<Image>();
        Transform child = this.gameObject.transform.GetChild(0);
        Image image = child.GetComponent<Image>();

        if (image.sprite != Resources.Load("None"))
        {
            print("cos tu jest");
            IInventoryItem item = _Inventory.mItems[index];

            if (item != null)
            {
                _Inventory.RemoveItem(item, index);
                item.OnDrop();
            }
        }
        else
        {
            print("nic tu nie ma");
        }
    }


}
