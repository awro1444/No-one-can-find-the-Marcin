using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveThisToPortier : MonoBehaviour
{
    public GameObject colaCan;
    public GameObject door;
    public GameObject uiObject2;
    public GameObject portierInfo;

    public GameObject uiObject;
    private Animator _animator;
    public bool ifOpened;

    void Start()
    {
        _animator = door.GetComponent<Animator>();
        //uiObject = GameObject.Find("portier");
        //uiObject.SetActive(false);
        ifOpened = false;
        uiObject.SetActive(false);
        uiObject2.SetActive(false);
        
    }

    void OnTriggerEnter(Collider player)
    {
        if (ifOpened == false)
        {
            if (player.gameObject.tag == "cola")
            {

                // Destroy(uiObject);
                //uiObject.SetActive(false);
                ifOpened = true;
                Destroy(portierInfo);
                Destroy(uiObject);
                uiObject2.SetActive(true);
                OpenDoor();
                StartCoroutine("WaitForSec");


            }
        }

    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(2);
        Destroy(colaCan);
        Destroy(uiObject2);
       
        //Destroy(gameObject); info tylko raz

    }

    public void OpenDoor()
    {
        _animator.SetBool("open", true);
    }
}
