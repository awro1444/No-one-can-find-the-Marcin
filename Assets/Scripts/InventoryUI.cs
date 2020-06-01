using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI : MonoBehaviour
{
    public Inventory Inventory;
    private int localIndex = 0;
    string itemName = "";

    void Start()
    {
        Inventory.ItemAdded += InventoryScript_ItemAdded;
        Inventory.ItemRemoved += Inventory_ItemRemoved;

    }



    private void InventoryScript_ItemAdded(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");
        //print("BBBBBBBBBB");
        //print(inventoryPanel);
        foreach (Transform slot in inventoryPanel)
        {

            Transform imageTransform = slot.GetChild(0).GetChild(0);
            Image image = imageTransform.GetComponent<Image>();
            //ItemDrag itemDrag = imageTransform.GetComponent<ItemDrag>();
            //print("aa");

            //if (!image.enabled)
            if (image.sprite == Resources.Load("None"))
            {
                //print("free slot");
                image.enabled = true;
                image.sprite = e.Item.Image;

                break;
            }

            //image.enabled = true;
            //image.sprite = e.Item.Image;

        }
    }

    private void Inventory_ItemRemoved(object sender, InventoryEventArgs e)
    {
        Transform inventoryPanel = transform.Find("InventoryPanel");

        int i = 0;

        foreach (Transform slot in inventoryPanel)
        {
            //print(Inventory.publicIndex);
            if (i == Inventory.publicIndex)
            {
                Transform imageTransform = slot.GetChild(0).GetChild(0);
                Image image = imageTransform.GetComponent<Image>();
                //ItemDrag itemDrag = imageTransform.GetComponent<ItemDrag>();


                /*
                if (itemDrag.Item.Equals(e.Item))
                {
                    print("image enabled");
                    image.enabled = false;
                    image.sprite = null;
                    itemDrag.Item = null;
                    break;
                }
                */

                //print("image enabled");
                image.enabled = false;
                image.sprite = null;
                //itemDrag.Item = null;
                break;
            }
            i++;

        }

        Image nextImage = inventoryPanel.GetChild(Inventory.publicIndex + 1).GetChild(0).GetChild(0).GetComponent<Image>();
        if (nextImage.enabled)
        {
            //print("cos tam dalej jest");
            int j = 0;
            foreach(Transform slot in inventoryPanel)
            {
                //print("foreach");
                if(j > Inventory.publicIndex)
                {
                    //print("if");
                    Image currentImage = slot.GetChild(0).GetChild(0).GetComponent<Image>();
                    Image previousImage = inventoryPanel.GetChild(j-1).GetChild(0).GetChild(0).GetComponent<Image>();

                    if (currentImage.enabled)
                    {
                        previousImage.enabled = true;
                        previousImage.sprite = currentImage.sprite;
                        currentImage.enabled = false;
                        currentImage.sprite = null;
                        

                    }
                    //przesuwamy
                    


                }
                j++;
            }
        }
        else
        {
            print("dalej nic nie ma");
        }


    }


}
