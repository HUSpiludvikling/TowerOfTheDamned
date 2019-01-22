using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopActivator : MonoBehaviour {

    [SerializeField]
    private ShopPanel shopPanel;

    

	// Use this for initialization
	void Start () {
        shopPanel = GetComponentInChildren<ShopPanel>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Shop"))
        {
            shopPanel.SetStateRecursive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Shop"))
        {
            shopPanel.SetStateRecursive(false);
        }
    }
}
