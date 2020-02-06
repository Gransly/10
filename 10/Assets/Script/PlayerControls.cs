using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerControls : MonoBehaviour
{
    private HUD hud;
    
    public float movespeed;
    public float walkspeed;
    public float runspeed;

    public float jumpStamiaMin;
    public float staminaMin ;
    private float stamina = 100f;
    private float timerToRegenStamina = 5f;
    private float timeToRegenStamina = 1f;
    private float staminaRegenSpeed = 15f;
    
    private Transform camTransform;
    public float jumpforce;
    
    private Transform playerTransform;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    private void Awake()
    {
        hud = GameObject.FindGameObjectWithTag("Canvas").GetComponent<HUD>();
        playerTransform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        camTransform = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Transform>();
    }

    void Update()
    {
        if (stamina > 0  && Input.GetKey(KeyCode.LeftShift) && ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.A)) ))
        {
            movespeed = runspeed;
            ManaWaste();
        }
        else
        {
            movespeed = walkspeed;
            if (timerToRegenStamina < timeToRegenStamina)
            {
                timerToRegenStamina += Time.deltaTime; 
            }
            else if (timerToRegenStamina >= timeToRegenStamina &&  stamina < 100f)
            {
                Regeniration();  
            }
        }
        
        if (Input.GetKey(KeyCode.W))
        {
          rb.AddForce(camTransform.forward* movespeed * Time.fixedDeltaTime);
        }
        
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-camTransform.forward* movespeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-camTransform.right* movespeed * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(camTransform.right* movespeed * Time.fixedDeltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space) && stamina > 30f)
        {
            stamina -= jumpStamiaMin * Time.deltaTime;
            hud.staminaBar.fillAmount = stamina / 100;
            stamina = Mathf.Clamp(stamina, 0, 100);
            timerToRegenStamina = 0f;
            rb.AddForce(Vector3.up* jumpforce * Time.fixedDeltaTime);
        }
    }

    private void Regeniration()
    {
        stamina += staminaRegenSpeed * Time.deltaTime;
        hud.staminaBar.fillAmount = stamina / 100;
        stamina = Mathf.Clamp(stamina, 0, 100);
    }

    private void ManaWaste()
    {
        stamina -= staminaMin * Time.deltaTime;
        hud.staminaBar.fillAmount = stamina / 100;
        stamina = Mathf.Clamp(stamina, 0, 100);
        timerToRegenStamina = 0f; 
    }
}
