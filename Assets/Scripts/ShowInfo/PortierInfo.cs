using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortierInfo : MonoBehaviour
{
    public GameObject uiObject;
    //public GameObject uiObject2;
    // Start is called before the first frame update
    void Start()
    {
        uiObject.SetActive(false);
       // uiObject2.SetActive(false);
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider player)
    {
        if(uiObject!=null){
            if (player.gameObject.tag == "MC")
            {
                uiObject.SetActive(true);
                StartCoroutine("WaitForSec");

            }
        }

    }


    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        if (uiObject != null)
        {
            uiObject.SetActive(false);
        }
            //Destroy(uiObject);
            //Destroy(gameObject); //info tylko raz
            //SceneManager.LoadScene("Menu");
            //Application.Quit();

        }
}
