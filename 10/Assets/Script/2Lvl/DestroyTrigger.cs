using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class DestroyTrigger : MonoBehaviour
{
    public Object gate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("PLayer2")  )
        {
            Destroy(gate);
            Destroy(gameObject);
            
        }
    }
}
