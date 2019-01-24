using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetZombieDestination : MonoBehaviour {
    Vector3 Destination;
    Transform PlayerTrans;

    [Range (1f,10f)]
    [SerializeField]
    float MinDistanceToPlayer;
    NavMeshAgent Agent;
    
	// Use this for initialization
	void Start () {
        Destination = GameObject.FindGameObjectWithTag("Tower").transform.position;
        Agent = GetComponent<NavMeshAgent>();
        Agent.SetDestination(Destination);

        PlayerTrans = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
        
        if (Vector3.Distance(transform.position, PlayerTrans.position) <= MinDistanceToPlayer)
        {
            Agent.SetDestination(PlayerTrans.position);
        }
        else
        {
            Agent.SetDestination(Destination);
            

        }
    }
}
