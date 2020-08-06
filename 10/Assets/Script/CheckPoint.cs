using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private CheckPointMaster check;
         public GameObject coin;
         private AudioSource checkpointSound;
     
         private void Start()
         {
             check = GameObject.FindGameObjectWithTag("CPM").GetComponent<CheckPointMaster>();
             checkpointSound = GetComponent<AudioSource>();
         }
     
         private void OnTriggerEnter(Collider other)
         {
             if (other.CompareTag("Player"))
             {
                 check.lastCheckpointPose = transform.position;
                 checkpointSound.Play();
                 Destroy(coin);
             }
         }
}
