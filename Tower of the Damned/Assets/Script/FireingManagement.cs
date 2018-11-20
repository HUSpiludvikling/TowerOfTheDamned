using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireingManagement : MonoBehaviour {
    public GameObject Arrow;
    public string Firekey = "Fire1";

    [Range(1f,50f)]
    public float ForceMod = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown(Firekey))
        {
            Fire();
        }
	}

    private void Fire()
    {
        GameObject temp;
        temp = Instantiate(Arrow, transform.position + transform.forward, transform.rotation * Arrow.transform.rotation);
        temp.GetComponent<Rigidbody>().AddForce(transform.forward * ForceMod, ForceMode.Impulse);
    }
}
