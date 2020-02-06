using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevateObjects : MonoBehaviour
{
    public Rigidbody objectRb;
    public float elevForce;
    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("ElevateObject"))
        {
            objectRb.AddForce(Vector3.up * elevForce * Time.fixedDeltaTime);
        }
    }
}
