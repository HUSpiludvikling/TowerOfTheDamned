using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class Health : MonoBehaviour {
    public UnityEvent DeathEvent;
    //Værdier og referencer
    [SerializeField]
    private int currentHealth = 100;

	// Use this for initialization
	void Start () {
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
            DeathEvent.Invoke();
        }
    }
}
