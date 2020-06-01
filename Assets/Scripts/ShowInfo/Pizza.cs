using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pizza : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);

    }

    void OnTriggerEnter()
    {
        uiObject.SetActive(true);
       
    }

    void OnTriggerExit()
    {
        uiObject.SetActive(false);
      
    }
}
