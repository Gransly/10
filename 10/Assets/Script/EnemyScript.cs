using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{ 
    private Transform player;
    public float move_speed;
    public float rotation_speed;
    private Transform enemy;

    public float enemyLookDistance;
    public float attackDistance;
    private float fpsTargetDistance;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemy = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        fpsTargetDistance = Vector3.Distance(player.position, transform.position);
        var look_dir = player.position - enemy.position;
        look_dir.y = 0;
        if (fpsTargetDistance < enemyLookDistance)
        {
            enemy.rotation = Quaternion.Slerp(enemy.rotation,Quaternion.LookRotation(look_dir),rotation_speed*Time.deltaTime);
        }

        if (fpsTargetDistance < attackDistance)
        {
            enemy.position += enemy.forward * move_speed * Time.deltaTime; 
        }
        
    }
}
