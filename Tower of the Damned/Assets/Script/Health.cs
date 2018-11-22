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

    // Use this for initialization
    void Awake () {
        DeathEvent = new UnityEvent();
	}
	
	// Update is called once per frame
	void Update () {
        
	}


    internal void DealDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        if (currentHealth <= 0)
        {
            //Send døds signal
            DeathEvent.Invoke();
        }
    }
}
