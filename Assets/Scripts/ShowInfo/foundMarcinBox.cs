using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class foundMarcinBox : MonoBehaviour
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
            StartCoroutine("WaitForSec");
            
        }

    }


    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        uiObject.SetActive(false);
        Destroy(uiObject);
        Destroy(gameObject); //info tylko raz
        SceneManager.LoadScene("Menu");
        //Application.Quit();

    }
}
