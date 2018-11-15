using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    //Værdier og referencer
    [SerializeField]
    private int currentHealth = 100;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal void DealDamage(int damage)
    {
        currentHealth = currentHealth - damage;
    }
}
