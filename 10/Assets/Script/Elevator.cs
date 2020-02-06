using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private Rigidbody pleyrRb;
    public float elevForce;

    private void Awake()
    {
        pleyrRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            pleyrRb.AddForce(Vector3.up * elevForce * Time.fixedDeltaTime);
        }
    }
}
