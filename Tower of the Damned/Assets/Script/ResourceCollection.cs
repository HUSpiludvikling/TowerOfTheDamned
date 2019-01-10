using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceCollection : MonoBehaviour {
    public int Lumber;
    public int Stone;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void AddLumber(int amount)
    {
        Lumber += amount;
    }
    public void AddStone(int amount)
    {
        Stone += amount;
    }
}
