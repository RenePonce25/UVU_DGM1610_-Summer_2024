using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyName : MonoBehaviour
{
    public string myName = "none";

    void Start()
    {
        Debug.Log("I am alive and my name is " + myName);
    }
}
