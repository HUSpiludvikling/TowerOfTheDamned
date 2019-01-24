using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoping : MonoBehaviour {

    private FireingManagement fireingManagement;

    private ResourceCollection Resource;

    public Text textFedback;

	// Use this for initialization
	void Start () {
        fireingManagement = GetComponentInChildren<FireingManagement>();
        Resource = GetComponent<ResourceCollection>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpgradeDamage(int Amonut)
    {
        int Price = Amonut * 10;
        if (Resource.Lumber >= Price)
        {
            Resource.Lumber -= Price;
            fireingManagement.UpgradeDamage(Amonut);
        }
    }

}
