using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class EnemyDie : MonoBehaviour
{
    public Object Enemy;
    public AudioSource enemyDeathSound;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            enemyDeathSound.Play();
            Destroy(Enemy);
        }
    }
    
}
