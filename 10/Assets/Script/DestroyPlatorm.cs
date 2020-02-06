using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class DestroyPlatorm : MonoBehaviour
{

    public Object destroyObj;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(destroyObj);
            Destroy(gameObject);
        }
    }
}
