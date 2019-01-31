using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerShoping : MonoBehaviour {

    private Health health;

    private ResourceCollection resource;

	// Use this for initialization
	void Start () {
        health = GetComponent<Health>();
        resource = GameObject.FindGameObjectWithTag("Player").GetComponent<ResourceCollection>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpgardeHealth(int amount)
    {
        int Price = amount * 5;
        if (resource.Stone >= Price)
        {
            resource.Stone -= Price;
            health.UpgateHealth(amount);
        }

    }

}
