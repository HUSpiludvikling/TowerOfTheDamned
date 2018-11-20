using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DerstroyOnTimer : MonoBehaviour {
    [Range(1f,30f)]
    public float Timer = 10f;
	// Use this for initialization
	void Start () {
        Destroy(this.gameObject, Timer);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
