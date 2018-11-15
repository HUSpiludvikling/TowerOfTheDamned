using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour {

    [SerializeField]
    private int Damage = 10;

    [SerializeField]
    private string damageTag = "Tower";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag(damageTag))
        {
            collision.transform.GetComponent<Health>().DealDamage(Damage);
        }
        else
        {

        }
    }

    
}
