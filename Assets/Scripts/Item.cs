using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IInventoryItem
{

    public GameObject tempParent;
    public string name;

    public string Name
    {
        get
        {
            return name;
        }
    }

    public Sprite _Image = null;

    public Sprite Image
    {
        get
        {
            return _Image;
        }
    }

    public void OnPickup()
    {
        gameObject.SetActive(false);
    }

    public void OnDrop()
    {
        //print("on drop2");
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        /*
        if (Physics.Raycast(ray, out hit, 1000))
        {
            print("on drop");
            gameObject.SetActive(true);
            //gameObject.transform.position = hit.point;
            gameObject.transform.position = tempParent.transform.position;

        }
        */

        //print("on drop");
        gameObject.SetActive(true);
        //gameObject.transform.position = hit.point;
        gameObject.transform.position = tempParent.transform.position;

    }
}
