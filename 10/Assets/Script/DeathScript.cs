using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{

    public Transform pl1;
    public Transform pl2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player1") || other.CompareTag("PLayer2"))
        {
            pl1.position = new Vector3(-0.68f,-0.35f,-2.41f);
            pl2.position = new Vector3(-3.63f,-0.44f,-2.141384f);
        }
    }
}
