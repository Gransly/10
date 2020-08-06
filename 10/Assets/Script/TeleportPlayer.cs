using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportPlayer : MonoBehaviour
{
    public Transform teleport2;
    public GameObject something;
    public GameObject coin;
    public AudioSource bossMusic;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            something.transform.position = teleport2.transform.position;
            bossMusic.Play();
            Destroy(coin);
        }
    }
}
