using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DealDamage : MonoBehaviour {

    [SerializeField]
    private int Damage = 10;

    [SerializeField]
    private string[] damageTags;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < damageTags.Length; i++)
        {
            if (collision.transform.CompareTag(damageTags[i]))
            {
                collision.transform.GetComponent<Health>().DealDamage(Damage);
            }
            else
            {

            }
        }
        
    }

    
}
