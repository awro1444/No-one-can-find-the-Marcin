﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPad1 : MonoBehaviour
{
    //public bool isClicked = false;
    private Animator _animator;

    public string curPassword = "1234";
    public string input;
    public bool onTrigger;
    public bool doorOpen;
    public bool keypadScreen;
// public Transform doorHinge;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "MC")
        {
            onTrigger = true;
        }
    }

    void OnTriggerExit(Collider player)
    {
        if (player.gameObject.tag == "MC")
        {
            onTrigger = false;
            keypadScreen = false;
            input = "";
        }
    }

    void Update()
    {
        if (input == curPassword)
        {
            doorOpen = true;
        }

        if (doorOpen)
        {
            //var newRot = Quaternion.RotateTowards(doorHinge.rotation, Quaternion.Euler(0.0f, -90.0f, 0.0f), Time.deltaTime * 250);
            //doorHinge.rotation = newRot;
            _animator.SetInteger("open", 1);

        }
    }

    void OnGUI()
    {
        if (!doorOpen)
        {
            if (onTrigger)
            {
               // GUI.Box(new Rect(0, 0, 200, 25), "Wciśnij 'E' aby wpisać kod");

                //if (Input.GetKeyDown(KeyCode.E))
                //{
                    keypadScreen = true;
                    onTrigger = false;
                //}
            }

            if (keypadScreen)
            {
                GUI.Box(new Rect(0, 0, 320, 455), "");
                GUI.Box(new Rect( 5, 5, 310, 25), input);

                if (GUI.Button(new Rect(5, 35, 100, 100), "1"))
                {
                    input = input + "1";
                }

                if (GUI.Button(new Rect(110, 35, 100, 100), "2"))
                {
                    input = input + "2";
                }

                if (GUI.Button(new Rect(215, 35, 100, 100), "3"))
                {
                    input = input + "3";
                }

                if (GUI.Button(new Rect(5, 140, 100, 100), "4"))
                {
                    input = input + "4";
                }

                if (GUI.Button(new Rect(110, 140, 100, 100), "5"))
                {
                    input = input + "5";
                }

                if (GUI.Button(new Rect(215, 140, 100, 100), "6"))
                {
                    input = input + "6";
                }

                if (GUI.Button(new Rect(5, 245, 100, 100), "7"))
                {
                    input = input + "7";
                }

                if (GUI.Button(new Rect(110, 245, 100, 100), "8"))
                {
                    input = input + "8";
                }

                if (GUI.Button(new Rect(215, 245, 100, 100), "9"))
                {
                    input = input + "9";
                }

                if (GUI.Button(new Rect(110, 350, 100, 100), "0"))
                {
                    input = input + "0";
                }

                if (GUI.Button(new Rect(215, 350, 100, 100), "X"))
                {
                    if (input.Length != 0)
                    {
                        input = input.Remove(input.Length - 1, 1);
                    }
                }


            }
        }
    }
}
