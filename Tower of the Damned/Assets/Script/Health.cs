using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Health : MonoBehaviour, IBarRepresentable {
    public UnityEvent DeathEvent;
    //Værdier og referencer
    [SerializeField]
    private int currentHealth = 100;

    public int currentHP { get; set; }

    public int MaxHP { get; set; }

    private UnityEvent takeDamageEvent;
    public UnityEvent TakeDamageEvent
    {
        get
        {
            return takeDamageEvent;
        }

        set
        {
            takeDamageEvent = value;
        }
    }



    // Use this for initialization
    void Awake () {
        currentHP = currentHealth;
        MaxHP = currentHealth;
        DeathEvent = new UnityEvent();
        TakeDamageEvent = new UnityEvent();
        
    }
	


    internal void DealDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        currentHP = currentHealth;
        TakeDamageEvent.Invoke();

        if (currentHealth <= 0)
        {
            //Send døds signal
            DeathEvent.Invoke();
        }
    }
}
