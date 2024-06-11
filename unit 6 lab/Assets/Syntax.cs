using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
  void Start()
  {
    //this will tell me the x position of my object
    
    /*now im writing two lines
     *hello
     * */
         Debug.Log(transform.position.x);
         if (transform.position.y <= 5f)
         {
             Debug.Log("im about to hit the ground");
         }
  }
}
