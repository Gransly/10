using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextBoss : MonoBehaviour
{
    public GameObject uiText;

    private void Awake()
    {
        uiText.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            uiText.SetActive(true);
            StartCoroutine(WaitForSec());
        }
    }

    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(5);
        Destroy(uiText);
        Destroy(gameObject);
    }
}
