using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private CheckPointMaster check;

    private void Start()
    {
        check = GameObject.FindGameObjectWithTag("CPM").GetComponent<CheckPointMaster>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            check.lastCheckpointPose = transform.position;
        }
    }
}
