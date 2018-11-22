using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieZombie : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Health>().DeathEvent.AddListener(Die);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void Die()
    {
        Destroy(gameObject);
    }


}
