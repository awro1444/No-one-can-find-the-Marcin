using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float throwForce = 600;
    Vector3 objectPos;
    float distance;

    public bool canHold = true;
    //public GameObject item;
    public GameObject tempParent;
    public bool isHolding = false;

    public Transform destination;
    public bool isClicked = false;

    public Inventory inventory;

    void Update()
    {
        distance = Vector3.Distance(this.transform.position, tempParent.transform.position);
        if (distance >= 4f)
        {
            isHolding = false;
        }
        //check if isholdin
        if (isHolding == true)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            this.transform.position = tempParent.transform.position;
            this.transform.SetParent(tempParent.transform);

            if (Input.GetMouseButtonDown(1))
            {
                //throw
            }

            if (Input.GetKeyDown(KeyCode.G))
            {
                isHolding = false;
            }

            if (Input.GetKeyDown(KeyCode.I))
            {
                //print("inventory");
                IInventoryItem item = this.GetComponent<IInventoryItem>();
                if (item != null)
                {
                    inventory.AddItem(item);
                }
            }


        }
        else
        {
            objectPos = this.transform.position;
            this.transform.SetParent(null);
            GetComponent<Rigidbody>().useGravity = true;
            this.transform.position = objectPos;
        }

    }

    void OnMouseDown()
    {
        if (distance <= 4f)
        {
            isClicked = !isClicked;
            if (isClicked)
            {
                isHolding = true;
                GetComponent<Rigidbody>().useGravity = false;
                GetComponent<Rigidbody>().detectCollisions = true;
            }
            else
            {
                isHolding = false;

            }

        }


        /*
        isClicked = !isClicked;
        if (isClicked)
        {
            //GetComponent<BoxCollider>().enabled = false;
            GetComponent<Rigidbody>().useGravity = false;
            this.transform.position = destination.position;
            this.transform.parent = GameObject.Find("Destination").transform;
        }
        else
        {
            
            this.transform.parent = null;
            GetComponent<Rigidbody>().useGravity = true;
            //GetComponent<BoxCollider>().enabled = true;
        }
        */


    }



}

