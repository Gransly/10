using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoopPLate : MonoBehaviour
{
    public GameObject door;
    private Animator rockAnim;
    public AudioSource pressSound;

    private void Start()
    {
        rockAnim = door.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PLayer2") || other.CompareTag("Player1"))
        {
            pressSound.Play();
            rockAnim.SetTrigger("IsUp");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PLayer2") || other.CompareTag("Player1"))
        {
            pressSound.Play();
            rockAnim.SetTrigger("IsDown");
        }
    }
}
