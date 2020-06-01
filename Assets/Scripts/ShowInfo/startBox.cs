using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startBox : MonoBehaviour
{
    public GameObject uiObject;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(true);

    }

    void OnTriggerExit()
    {
        uiObject.SetActive(false);
        Destroy(uiObject);
        Destroy(gameObject); //info tylko raz
    }

}
