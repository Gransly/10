using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class BossDie : MonoBehaviour
{
    public Object Enemy;
    public float jumpForce;
    public GameObject text;
    
    private int bossHealth = 3;
    private Rigidbody player;
    private bool isInvincible = true;
    private Transform camera;
    public AudioSource bossMusic;
    public AudioSource bossDieMusic;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        camera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && isInvincible)
        {
            bossHealth--;
            
            isInvincible = false;
            StartCoroutine(GetInvulnerable());
            
            player.AddForce(camera.up * jumpForce * Time.fixedDeltaTime);
        }

        if (bossHealth == 0)
        {
            bossMusic.Stop();
            Die();
        }
    }
    private void Die()
    {
        bossDieMusic.Play();
        Destroy(Enemy);
        text.SetActive(true);
        
    }
    
    IEnumerator GetInvulnerable()
    { 
        yield return    new WaitForSeconds(3f);
        isInvincible = true;
    }
}
