using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointMaster : MonoBehaviour
{
    // Start is called before the first frame update
    private static CheckPointMaster instance;
    public Vector3 lastCheckpointPose;
    public Vector3 firstChecpointPose;
}

