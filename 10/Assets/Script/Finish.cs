using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject uiText;

    private void Awake()
    {
        uiText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiText.SetActive(true);
            Destroy(gameObject);
        }
    }

    
        
    
}
