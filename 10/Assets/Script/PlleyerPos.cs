using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlleyerPos : MonoBehaviour
{
    private CheckPointMaster check;
    void Start()
    {
        check = GameObject.FindGameObjectWithTag("CPM").GetComponent<CheckPointMaster>();
        transform.position = check.lastCheckpointPose;
    }
}
