using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseDoor : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator _animator;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

   void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "MC")
        {

            _animator.SetInteger("open", 1);

        }

    }

     void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "MC")
        {

            _animator.SetInteger("open", 2);

        }

    }
}
