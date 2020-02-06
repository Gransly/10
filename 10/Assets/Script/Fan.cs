using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    private Rigidbody pleyrRb;
    public float elevForce;
    public Rigidbody enemyRb;
    private void Awake()
    {
        pleyrRb = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            pleyrRb.AddForce(Vector3.left * elevForce * Time.fixedDeltaTime);
        }
        
        if (other.CompareTag("Enemy"))
        {
            enemyRb.AddForce(Vector3.left * elevForce * Time.fixedDeltaTime);
        }
    }
}
