using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroycharacter : MonoBehaviour
{
    public GameObject destroyedplayer;
    void OnCollisionEnter()
    {
        Destroy(gameObject);
        Instantiate(wreckedVersion,transform.position,transform.rotation);
    }
        
    }
}
