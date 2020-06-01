using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notThisWayBox : MonoBehaviour
{
    public GameObject uiObject;

    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "MC")
        {
            uiObject.SetActive(true);
            //StartCoroutine("WaitForSec");

        }

    }

    void OnTriggerExit()
    {
        uiObject.SetActive(false);
    }

    /*IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        uiObject.SetActive(false);
        //Destroy(uiObject);
        //Destroy(gameObject); info tylko raz

    }*/
}
