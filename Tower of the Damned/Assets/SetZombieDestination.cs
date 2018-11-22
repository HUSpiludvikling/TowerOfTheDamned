using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetZombieDestination : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Vector3 Destination = GameObject.FindGameObjectWithTag("Tower").transform.position;

        GetComponent<NavMeshAgent>().SetDestination(Destination);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
