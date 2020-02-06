using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisapearingPlatform : MonoBehaviour
{
    public float disapearingTime;
    public float showTime;
    
    private MeshCollider platformCollider;
   private MeshRenderer platformMesh;

    private void Awake()
    {
       platformCollider = GetComponent<MeshCollider>();
       platformMesh = GetComponent<MeshRenderer>();
    }

    void OnTriggerEnter(Collision coll)
        {
            if (coll.collider.CompareTag("Player"))
            {
                StartCoroutine(Hide());
                StartCoroutine(Show());
            }
        }
    
    

        IEnumerator Hide()
        {
            yield return new WaitForSeconds(disapearingTime);
            platformCollider.enabled = false;
            platformMesh.enabled = false;
        }
        
        IEnumerator Show()
        {
            yield return new WaitForSeconds(showTime);
            platformCollider.enabled = true;
            platformMesh.enabled = true;
        }
}
