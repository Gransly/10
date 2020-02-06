using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOffOn : MonoBehaviour
{
    public BoxCollider colliderToOff;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !colliderToOff.enabled) 
        {
            colliderToOff.enabled = true;
        }
        else
        {
            if (other.CompareTag("Player") && colliderToOff.enabled)
            {
                colliderToOff.enabled = false;
            }
        }
    }
}
