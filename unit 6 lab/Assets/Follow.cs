using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
   public Transform objectTofollow;
   public float followSpeed = 1;

   private void Update()
   {
      var delta = objectTofollow.position - transform.position;
      transform.position += delta * Time.deltaTime * followSpeed;
   }
}
