using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewLvl : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Application.LoadLevel(1);
        }
        
    }
}
